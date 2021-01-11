using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CG.DAC;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace CG
{
    public partial class frmConsultaSaldoCentro : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable _dtCuenta = new DataTable();
        //DataTable dtConsolidado = new DataTable();
        DataTable dtDetallado = new DataTable();
		DataRowView drCuenta;

        public frmConsultaSaldoCentro()
        {
            InitializeComponent();
            this.Load += FrmConsultaSaldoCentro_Load;
        }

        private void FrmConsultaSaldoCentro_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime fechatemp = DateTime.Today;
                this.dtpFechaInicial.EditValue = new DateTime(fechatemp.Year, fechatemp.Month, 1);
                if (fechatemp.Month + 1 < 13)
                { this.dtpFechaFinal.EditValue = new DateTime(fechatemp.Year, fechatemp.Month + 1, 1).AddDays(-1); }
                else
                { this.dtpFechaFinal.EditValue = new DateTime(Convert.ToInt32(fechatemp.Year) + 1, 1, 1).AddDays(-1); }


                _dtCuenta = CuentaContableDAC.GetData(-1, -1, -1, "*", "*", "*", "*","*" ,"*", "*", -1, -1, -1, 1, -1, -1).Tables[0];

                Util.Util.ConfigLookupEdit(this.slkupCuenta, _dtCuenta, "Descr", "IDCuenta",400,300);
                Util.Util.ConfigLookupEditSetViewColumns(this.slkupCuenta, "[{'ColumnCaption':'Cuenta','ColumnField':'Cuenta','width':30},{'ColumnCaption':'Descripcion','ColumnField':'Descr','width':70}]");
                this.slkupCuenta.Properties.ShowClearButton = true;
                this.slkupCuenta.Properties.PopupFormSize = new Size(400, 300);
                this.slkupCuenta.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            long idCuenta = (this.slkupCuenta.EditValue == null) ? -1 : Convert.ToInt64(this.slkupCuenta.EditValue);

            DataSet DS = new DataSet();
           
			DS = ConsultasDAC.GetCentroByCuenta(idCuenta, Convert.ToDateTime(this.dtpFechaInicial.EditValue), Convert.ToDateTime(this.dtpFechaFinal.EditValue));
            dtDetallado = DS.Tables[0];
            this.grid.DataSource = dtDetallado;
           
            this.gridView1.Columns[0].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
        }

       

       

        private void btnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tempPath = System.IO.Path.GetTempPath();
            String FileName = System.IO.Path.Combine(tempPath, "lstSaldoCentro.xlsx");
            DevExpress.XtraPrinting.XlsxExportOptions options = new DevExpress.XtraPrinting.XlsxExportOptions()
            {
                SheetName = "Saldo Centro Costo"
            };


            this.gridView1.ExportToXlsx(FileName, options);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = FileName;
            process.StartInfo.Verb = "Open";
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            process.Start();
        }

        private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {
            if (this.gridView1.SelectedRowsCount > 0) {
                DataRow dr = this.gridView1.GetDataRow(this.gridView1.GetSelectedRows()[0]);
				drCuenta = (DataRowView)this.slkupCuenta.GetSelectedDataRow();
				if (drCuenta == null) {
					MessageBox.Show("Debe de seleccionar una cuenta Contable para poder visualizar el detalle");
					return;
				}
				if (Convert.ToBoolean(dr["Acumulador"]) == true)
				{
					Consultas.frmConsultaCuentaCentroHijas ofrmConsulta = new Consultas.frmConsultaCuentaCentroHijas(dr, (drCuenta != null) ? drCuenta.Row : null, Convert.ToDateTime(this.dtpFechaInicial.EditValue), Convert.ToDateTime(this.dtpFechaFinal.EditValue), Convert.ToDecimal(txtTipoCambio.Text), 2);
					ofrmConsulta.ShowDialog();
				}
				else
				{
					frmConsultaAsiento frmConsultaAsiento = new frmConsultaAsiento(dr,(drCuenta != null ) ? drCuenta.Row : null , Convert.ToDateTime(this.dtpFechaInicial.EditValue), Convert.ToDateTime(this.dtpFechaFinal.EditValue), Convert.ToDecimal(this.txtTipoCambio.Text));
					frmConsultaAsiento.ShowDialog();
				}
            }
        }

    private  void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
				if (drCuenta == null)
				{
					MessageBox.Show("Debe de seleccionar una cuenta Contable para poder visualizar el detalle");
					return;
				}
                DataRow dr = view.GetDataRow(view.GetSelectedRows()[0]);
                frmConsultaAsiento frmConsultaAsiento = new frmConsultaAsiento(dr,drCuenta.Row, Convert.ToDateTime(this.dtpFechaInicial.EditValue), Convert.ToDateTime(this.dtpFechaFinal.EditValue),Convert.ToDecimal(this.txtTipoCambio.Text));
                frmConsultaAsiento.ShowDialog();
                
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }



        private void dtpFechaFinal_EditValueChanged(object sender, EventArgs e)
        {
            CargarTipoCambio();
        }


        private void CargarTipoCambio()
        {
            if (this.dtpFechaFinal.EditValue != null)
            {
                DateTime Fecha = Convert.ToDateTime(this.dtpFechaFinal.EditValue);
                if (Fecha.Month + 1 < 13)																		             
                { Fecha = new DateTime(Fecha.Year, Fecha.Month + 1, 1).AddDays(-1); }
                else
                { Fecha = new DateTime(Convert.ToInt32(Fecha.Year) + 1, 1, 1).AddDays(-1); }

                double TipoCambio = TipoCambioDetalleDAC.GetLastTipoCambioFecha(Fecha);
                this.txtTipoCambio.Text = TipoCambio.ToString();
            }
        }
    
    }
}