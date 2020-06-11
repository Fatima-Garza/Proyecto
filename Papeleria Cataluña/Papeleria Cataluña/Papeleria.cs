using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace Papeleria_Cataluña
{
	public delegate void MiDelegado(string Nombre);
    class Papeleria  
	{
		public event MiDelegado pedido;
		private string _strNombre = "";

		public string nombre
		{
			get { return _strNombre; }
			set { _strNombre = value;
				pedido(nombre);
			}

		}
		private string _strDireccion;

		public string direccion
		{
			get { return _strDireccion; }
			set { _strDireccion = value; }
		}
		private int _intTelefono;

		public int telefono
		{
			get { return _intTelefono; }
			set { _intTelefono = value; }
				
			
		}		
		private string _strLapiz;

		public string lapiz
		{
			get { return _strLapiz; }
			set { _strLapiz = value; }
		}


		private string _strColores;

		public string colores
		{
			get { return _strColores; }
			set { _strColores = value; }
		}
		

		
		private string _strBorrador;

		public string borrador
		{
			get { return _strBorrador; }
			set { _strBorrador = value; }
		}
		
		private string _strCuaderno;

		public string cuadernos
		{
			get { return _strCuaderno; }
			set { _strCuaderno = value; }
		}
		private string _strTijeras;

		public string tijeras
		{
			get { return _strTijeras; }
			set { _strTijeras = value; }
		}
		private string _strPegamentoEnBarra;

		public string pegamentoenbarra
		{
			get { return _strPegamentoEnBarra; }
			set { _strPegamentoEnBarra = value; }
		}
		


















	}
}
