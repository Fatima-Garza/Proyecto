namespace Papeleria_Cataluña
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbLapiz = new System.Windows.Forms.ComboBox();
            this.lblLapiz = new System.Windows.Forms.Label();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.cmbBorrador = new System.Windows.Forms.ComboBox();
            this.cmbCuadernos = new System.Windows.Forms.ComboBox();
            this.cmbTijeras = new System.Windows.Forms.ComboBox();
            this.cmbPegamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBorrador = new System.Windows.Forms.Label();
            this.lblCuadernos = new System.Windows.Forms.Label();
            this.lblTijeras = new System.Windows.Forms.Label();
            this.lblPegamento = new System.Windows.Forms.Label();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lapiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tijeras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuadernos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PegamentoEnBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIngresesufoto = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.Seleccione = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Seleccione.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(27, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(85, 110);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(85, 64);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(104, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Moccasin;
            this.lblTelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTelefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTelefono.Location = new System.Drawing.Point(12, 117);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(65, 17);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Moccasin;
            this.lblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDireccion.Location = new System.Drawing.Point(7, 67);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(73, 17);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Moccasin;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNombre.Location = new System.Drawing.Point(6, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marque los articulos que necesita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(226, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "BIENVENIDO A PAPELERIA CATALUÑA";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Pink;
            this.btnSalir.Location = new System.Drawing.Point(887, 75);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbLapiz
            // 
            this.cmbLapiz.ForeColor = System.Drawing.Color.Salmon;
            this.cmbLapiz.FormattingEnabled = true;
            this.cmbLapiz.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Tres",
            "Cuatro"});
            this.cmbLapiz.Location = new System.Drawing.Point(21, 29);
            this.cmbLapiz.Name = "cmbLapiz";
            this.cmbLapiz.Size = new System.Drawing.Size(121, 21);
            this.cmbLapiz.TabIndex = 18;
            // 
            // lblLapiz
            // 
            this.lblLapiz.AutoSize = true;
            this.lblLapiz.BackColor = System.Drawing.Color.LightGray;
            this.lblLapiz.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLapiz.ForeColor = System.Drawing.Color.Black;
            this.lblLapiz.Location = new System.Drawing.Point(62, 13);
            this.lblLapiz.Name = "lblLapiz";
            this.lblLapiz.Size = new System.Drawing.Size(38, 14);
            this.lblLapiz.TabIndex = 19;
            this.lblLapiz.Text = "Lapiz";
            // 
            // cmbColores
            // 
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Tres",
            "Cuatro"});
            this.cmbColores.Location = new System.Drawing.Point(376, 29);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(115, 21);
            this.cmbColores.TabIndex = 21;
            // 
            // cmbBorrador
            // 
            this.cmbBorrador.FormattingEnabled = true;
            this.cmbBorrador.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Tres",
            "Cuatro"});
            this.cmbBorrador.Location = new System.Drawing.Point(201, 81);
            this.cmbBorrador.Name = "cmbBorrador";
            this.cmbBorrador.Size = new System.Drawing.Size(121, 21);
            this.cmbBorrador.TabIndex = 23;
            // 
            // cmbCuadernos
            // 
            this.cmbCuadernos.FormattingEnabled = true;
            this.cmbCuadernos.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Tres",
            "Cuatro"});
            this.cmbCuadernos.Location = new System.Drawing.Point(21, 81);
            this.cmbCuadernos.Name = "cmbCuadernos";
            this.cmbCuadernos.Size = new System.Drawing.Size(121, 21);
            this.cmbCuadernos.TabIndex = 25;
            // 
            // cmbTijeras
            // 
            this.cmbTijeras.FormattingEnabled = true;
            this.cmbTijeras.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Tres",
            "Cuatro"});
            this.cmbTijeras.Location = new System.Drawing.Point(201, 31);
            this.cmbTijeras.Name = "cmbTijeras";
            this.cmbTijeras.Size = new System.Drawing.Size(121, 21);
            this.cmbTijeras.TabIndex = 26;
            // 
            // cmbPegamento
            // 
            this.cmbPegamento.FormattingEnabled = true;
            this.cmbPegamento.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Tres",
            "Cuatro"});
            this.cmbPegamento.Location = new System.Drawing.Point(369, 81);
            this.cmbPegamento.Name = "cmbPegamento";
            this.cmbPegamento.Size = new System.Drawing.Size(121, 21);
            this.cmbPegamento.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Colores";
            // 
            // lblBorrador
            // 
            this.lblBorrador.AutoSize = true;
            this.lblBorrador.BackColor = System.Drawing.Color.LightGray;
            this.lblBorrador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrador.Location = new System.Drawing.Point(232, 65);
            this.lblBorrador.Name = "lblBorrador";
            this.lblBorrador.Size = new System.Drawing.Size(60, 14);
            this.lblBorrador.TabIndex = 31;
            this.lblBorrador.Text = "Borrador";
            // 
            // lblCuadernos
            // 
            this.lblCuadernos.AutoSize = true;
            this.lblCuadernos.BackColor = System.Drawing.Color.LightGray;
            this.lblCuadernos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuadernos.Location = new System.Drawing.Point(51, 64);
            this.lblCuadernos.Name = "lblCuadernos";
            this.lblCuadernos.Size = new System.Drawing.Size(71, 14);
            this.lblCuadernos.TabIndex = 33;
            this.lblCuadernos.Text = "Cuadernos";
            // 
            // lblTijeras
            // 
            this.lblTijeras.AutoSize = true;
            this.lblTijeras.BackColor = System.Drawing.Color.LightGray;
            this.lblTijeras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTijeras.ForeColor = System.Drawing.Color.Black;
            this.lblTijeras.Location = new System.Drawing.Point(233, 14);
            this.lblTijeras.Name = "lblTijeras";
            this.lblTijeras.Size = new System.Drawing.Size(47, 14);
            this.lblTijeras.TabIndex = 34;
            this.lblTijeras.Text = "Tijeras";
            this.lblTijeras.Click += new System.EventHandler(this.lblTijeras_Click);
            // 
            // lblPegamento
            // 
            this.lblPegamento.AutoSize = true;
            this.lblPegamento.BackColor = System.Drawing.Color.LightGray;
            this.lblPegamento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPegamento.Location = new System.Drawing.Point(366, 65);
            this.lblPegamento.Name = "lblPegamento";
            this.lblPegamento.Size = new System.Drawing.Size(125, 14);
            this.lblPegamento.TabIndex = 35;
            this.lblPegamento.Text = "Pegamento en barra";
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Direccion,
            this.Telefono,
            this.Lapiz,
            this.Tijeras,
            this.Colores,
            this.Cuadernos,
            this.Borrador,
            this.PegamentoEnBarra});
            this.dgvTabla.Location = new System.Drawing.Point(212, 245);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(942, 151);
            this.dgvTabla.TabIndex = 36;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Lapiz
            // 
            this.Lapiz.HeaderText = "Lapiz";
            this.Lapiz.Name = "Lapiz";
            // 
            // Tijeras
            // 
            this.Tijeras.HeaderText = "Tijeras";
            this.Tijeras.Name = "Tijeras";
            // 
            // Colores
            // 
            this.Colores.HeaderText = "Colores";
            this.Colores.Name = "Colores";
            // 
            // Cuadernos
            // 
            this.Cuadernos.HeaderText = "Cuadernos";
            this.Cuadernos.Name = "Cuadernos";
            // 
            // Borrador
            // 
            this.Borrador.HeaderText = "Borrador";
            this.Borrador.Name = "Borrador";
            // 
            // PegamentoEnBarra
            // 
            this.PegamentoEnBarra.HeaderText = "Pegamento En Barra";
            this.PegamentoEnBarra.Name = "PegamentoEnBarra";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Pink;
            this.btnAgregar.Location = new System.Drawing.Point(887, 131);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 37;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 109);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btnIngresesufoto
            // 
            this.btnIngresesufoto.BackColor = System.Drawing.Color.Pink;
            this.btnIngresesufoto.Location = new System.Drawing.Point(73, 255);
            this.btnIngresesufoto.Name = "btnIngresesufoto";
            this.btnIngresesufoto.Size = new System.Drawing.Size(75, 41);
            this.btnIngresesufoto.TabIndex = 40;
            this.btnIngresesufoto.Text = "Ingrese su foto";
            this.btnIngresesufoto.UseVisualStyleBackColor = false;
            this.btnIngresesufoto.Click += new System.EventHandler(this.btnIngresesufoto_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Pink;
            this.btnConsultar.Location = new System.Drawing.Point(887, 104);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 21);
            this.btnConsultar.TabIndex = 41;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // Seleccione
            // 
            this.Seleccione.BackColor = System.Drawing.Color.Transparent;
            this.Seleccione.Controls.Add(this.lblPegamento);
            this.Seleccione.Controls.Add(this.lblTijeras);
            this.Seleccione.Controls.Add(this.lblCuadernos);
            this.Seleccione.Controls.Add(this.lblBorrador);
            this.Seleccione.Controls.Add(this.label3);
            this.Seleccione.Controls.Add(this.cmbPegamento);
            this.Seleccione.Controls.Add(this.cmbTijeras);
            this.Seleccione.Controls.Add(this.cmbCuadernos);
            this.Seleccione.Controls.Add(this.cmbBorrador);
            this.Seleccione.Controls.Add(this.cmbColores);
            this.Seleccione.Controls.Add(this.lblLapiz);
            this.Seleccione.Controls.Add(this.cmbLapiz);
            this.Seleccione.Location = new System.Drawing.Point(332, 86);
            this.Seleccione.Name = "Seleccione";
            this.Seleccione.Size = new System.Drawing.Size(530, 119);
            this.Seleccione.TabIndex = 42;
            this.Seleccione.TabStop = false;
            this.Seleccione.Text = "Seleccione";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Pink;
            this.btnBorrar.Location = new System.Drawing.Point(887, 160);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 43;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Papeleria_Cataluña.Properties.Resources.foto_papeleria;
            this.ClientSize = new System.Drawing.Size(1170, 518);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.Seleccione);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnIngresesufoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Seleccione.ResumeLayout(false);
            this.Seleccione.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbLapiz;
        private System.Windows.Forms.Label lblLapiz;
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.ComboBox cmbBorrador;
        private System.Windows.Forms.ComboBox cmbCuadernos;
        private System.Windows.Forms.ComboBox cmbTijeras;
        private System.Windows.Forms.ComboBox cmbPegamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBorrador;
        private System.Windows.Forms.Label lblCuadernos;
        private System.Windows.Forms.Label lblTijeras;
        private System.Windows.Forms.Label lblPegamento;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIngresesufoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lapiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tijeras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuadernos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn PegamentoEnBarra;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox Seleccione;
        private System.Windows.Forms.Button btnBorrar;
    }
}

