﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CI
{
	public partial class frmDetallesPrestamos : Form
	{
		long IDTransaccion;
		public frmDetallesPrestamos(long pIDTransaccion)
		{
			InitializeComponent();
			this.IDTransaccion = pIDTransaccion;
		}

		private void frmDetallesPrestamos_Load(object sender, EventArgs e)
		{
			this.dtgDetallePrestamos.DataSource =  DAC.clsTransaccionPrestamoDAC.GetDetallePrestamos(this.IDTransaccion,null);
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
