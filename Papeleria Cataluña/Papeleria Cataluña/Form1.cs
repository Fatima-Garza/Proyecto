using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Papeleria_Cataluña
{
    public partial class Form1 : Form
    {
        
        Papeleria Mipapeleria = new Papeleria();
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void MetodoGestor(object sender, PropertyChangedEventArgs e)
        {
            MessageBox.Show("Se ha cambiado el valor de " + e.PropertyName);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                Mipapeleria.nombre = txtNombre.Text;
                Mipapeleria.direccion = txtDireccion.Text;
                Mipapeleria.telefono = int.Parse(txtTelefono.Text);
                Mipapeleria.lapiz = cmbLapiz.Text;
                Mipapeleria.tijeras = (cmbTijeras.Text);
                Mipapeleria.colores = (cmbColores.Text);
                Mipapeleria.cuadernos = (cmbCuadernos.Text);
                Mipapeleria.borrador = (cmbBorrador.Text);
                Mipapeleria.pegamentoenbarra =(cmbPegamento.Text);
                dgvTabla.Rows.Add(txtNombre.Text, txtDireccion.Text, txtTelefono.Text, cmbLapiz.Text, cmbTijeras.Text, cmbColores.Text, cmbCuadernos.Text, cmbBorrador.Text,cmbPegamento.Text);
                Insertar();
                
            }
            catch (Exception x )
            {

                MessageBox.Show(x.Message);
            }
            
        }
        public void  Insertar()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=papeleria;";

            string query = "INSERT INTO papeleria(`id`,`nombre`, `direccion`, `telefono`, `lapiz`, `tijeras`, `colores`, `cuadernos`,`borrador`, `pegamento en barra` ) VALUES ('Null' ,'" + txtNombre.Text + "', '" + txtDireccion.Text + "', " + txtTelefono.Text + ", '" + Mipapeleria.lapiz + "', '" + Mipapeleria.tijeras + "', '" + Mipapeleria.colores + "', '" + Mipapeleria.cuadernos + "' , '" + Mipapeleria.borrador+ "', '" + Mipapeleria.pegamentoenbarra + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Pedido registrado ");

                databaseConnection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            cmbLapiz.Text = "";
            cmbTijeras.Text = "";
            cmbColores.Text = "";
            cmbCuadernos.Text = "";
            cmbBorrador.Text = "";
            cmbPegamento.Text = "";

        }

        private void btnIngresesufoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Abrir = new OpenFileDialog();
                Abrir.Filter = "* .bmp; * .jpg; * .gif; * .png * | * .bmp; * .jpg; * .gif; * .png *";
                Abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                Abrir.Title = "Seleccione su foto";
                Abrir.RestoreDirectory = true;

                if (Abrir.ShowDialog() == DialogResult.OK)
                {
                    Text = Abrir.FileName;
                    pictureBox1.Image = Image.FromFile(Abrir.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    Text = "";
                    pictureBox1.Image = null;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("!Error al cargar la imagen: " + x);
            }
        }

        private void lblTijeras_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=papeleria;";

            string query = "SELECT * FROM papeleria";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            dgvTabla.Rows.Clear();

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgvTabla.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9));
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro nada");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mipapeleria.pedido += MetodoGestor;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=papeleria;";

            string pedido = dgvTabla.CurrentRow.Cells[0].Value.ToString();

            string query = "DELETE FROM papeleria WHERE Nombre = '" + pedido + "'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                MessageBox.Show("Pedido eliminado de la base de datos");

                databaseConnection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            /*try
            {
                int NombreCambiado = Papeleria.Editar(int.Parse(txtTelefono.Text), txtNombre.Text);
                if (NombreCambiado > 0)
                {
                    MessageBox.Show("Se edito el nombre ");
                }
                
            }
            catch (Exception x )
            {

                MessageBox.Show("Error : " + x.Message);
            }
            Mipapeleria.PropertyChanged += new PropertyChangedEventHandler(MetodoGestor);
            Mipapeleria.nombre = txtNombre.Text;
            Mipapeleria.telefono = int.Parse(txtTelefono.Text);
            Mipapeleria.direccion = txtDireccion.Text; */
        }
        public void MetodoGestor(string Nombre)
        {
            MessageBox.Show("El pedido de  "  + Nombre + "Se a capturado correctamente");
        }
        
    }
}
