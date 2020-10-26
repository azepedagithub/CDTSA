using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraLayout;
using Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO
{
    public partial class frmRecepcionMercaderia : Form
    {
        long IDEmbarque = -1;
        int IDProveedor, IDBodega;
        String OrdenCompra, Embarque;
        String sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";
        bool Confirmada = false;
        DataTable dtDatosEmbarque = new DataTable();
        DataTable dtDetalleEmbarque = new DataTable();
        DataTable dtRecepcionMercaderia = new DataTable();
        DataTable dtProductos = new DataTable();
        DataTable dtLotes = new DataTable();


        public frmRecepcionMercaderia(long IDEmbarque)
        {
            InitializeComponent();
            this.IDEmbarque = IDEmbarque;
        }



        private void frmRecepcionMeraderia_Load(object sender, EventArgs e)
        {

            dtProductos = DAC.clsEmbarqueDAC.GetProductosFromEmbarque(IDEmbarque).Tables[0];
            dtLotes = CI.DAC.clsLoteDAC.GetData(-1, -1, "*", "*").Tables[0];

            this.slkupGridIDProd.DataSource = dtProductos;
            this.slkupGridIDProd.DisplayMember = "IDProducto";
            this.slkupGridIDProd.ValueMember = "IDProducto";
            this.slkupGridIDProd.NullText = " --- ---";
            this.slkupGridIDProd.EditValueChanged += slkup_EditValueChanged;
            this.slkupGridIDProd.Popup += slkup_Popup;
            //this.slkupIDProducto.PopulateViewColumns();


            this.slkupGridLote.DataSource = dtLotes;
            this.slkupGridLote.DisplayMember = "LoteProveedor";
            this.slkupGridLote.ValueMember = "IDLote";
            this.slkupGridLote.NullText = " --- ---";
            this.slkupGridLote.EditValueChanged += slkupGridLote_EditValueChanged;
			EditorButton buttoAdd = new EditorButton( DevExpress.XtraEditors.Controls.ButtonPredefines.Plus,"Agregar",100,true,true,true, DevExpress.Utils.HorzAlignment.Center, null);
			this.slkupGridLote.Buttons.Add(buttoAdd);
			buttoAdd.Click += buttoAdd_Click;	
			
            
            this.slkupGridLote.Popup += slkup_Popup;


            this.slkupGridDescrProd.DataSource = dtProductos;
            this.slkupGridDescrProd.DisplayMember = "Descr";
            this.slkupGridDescrProd.ValueMember = "IDProducto";
            this.slkupGridDescrProd.NullText = " --- ---";
            this.slkupGridDescrProd.EditValueChanged += slkup_EditValueChanged;
            this.slkupGridDescrProd.Popup += slkup_Popup;
            
            CargarRecepcionMercaderia();
        }

		void buttoAdd_Click(object sender, EventArgs e)
		{
			MessageBox.Show("hi");
		}

        
   
        void slkup_EditValueChanged(object sender, EventArgs e)
        {
            
            SendKeys.Send("{TAB}");

        }

        private void slkup_Popup(object sender, EventArgs e)
        {
            DevExpress.Utils.Win.IPopupControl popupControl = sender as DevExpress.Utils.Win.IPopupControl;
            DevExpress.XtraLayout.LayoutControl layoutControl = popupControl.PopupWindow.Controls[2].Controls[0] as LayoutControl;

            SimpleButton clearButton = ((DevExpress.XtraLayout.LayoutControlItem)layoutControl.Items.FindByName("lciClear")).Control as SimpleButton;
            SimpleButton findButton = ((DevExpress.XtraLayout.LayoutControlItem)layoutControl.Items.FindByName("lciButtonFind")).Control as SimpleButton;

            clearButton.Text = "Limpiar";
            findButton.Text = "Buscar";
        }

        void slkupGridLote_EditValueChanged(object sender, EventArgs e)
        {
            SearchLookUpEdit editor = sender as SearchLookUpEdit;
            DataRowView dr = (DataRowView)editor.GetSelectedDataRow();

            this.gridViewIngresoMercaderia.PostEditor();
			if (dr == null)
			{
				this.gridViewIngresoMercaderia.SetFocusedRowCellValue("FechaVencimiento", null);
			}
			else
			{
				DateTime Fecha = Convert.ToDateTime(dr["FechaVencimiento"]);
				this.gridViewIngresoMercaderia.SetFocusedRowCellValue("FechaVencimiento", Fecha);
			}

            SendKeys.Send("{TAB}");

        }

        private void UpdateControlsFromData(DataTable dt) {
            DataRow dr = dt.Rows[0];
            this.txtOrdenCompra.Text = dr["OrdenCompra"].ToString();
            this.txtFactura.Text = dr["NumFactura"].ToString();
            this.txtEmbarque.Text = dr["Embarque"].ToString();
            this.txtProveedor.Text = dr["IDProveedor"].ToString() + " - " + dr["Nombre"].ToString();
            this.dtpFecha.EditValue = DateTime.Now;
        }

        private void CargarRecepcionMercaderia() {
            this.dtDetalleEmbarque = DAC.clsEmbarqueDetalleDAC.Get(IDEmbarque).Tables[0];
            this.dtRecepcionMercaderia = DAC.clsRecepcionMercaderiaDAC.Get ((int)IDEmbarque).Tables[0];
            this.dtDatosEmbarque = DAC.clsRecepcionMercaderiaDAC.ObtenerDatosGenerales((int)IDEmbarque).Tables[0];
           
            UpdateControlsFromData(dtDatosEmbarque);

            if (this.dtRecepcionMercaderia.Rows.Count == 0)
            {
                this.dtRecepcionMercaderia.Clear();
                foreach (DataRow row in dtDetalleEmbarque.Rows)
                {
                    DataRow fila = this.dtRecepcionMercaderia.NewRow();
                    fila["IDEmbarque"] = row["IDEmbarque"];
                    fila["IDProducto"] = row["IDProducto"];
                    //fila["FechaVencimiento"] = row["IDProducto"];
                    fila["Cantidad"] = row["CantidadAceptada"];

                    this.dtRecepcionMercaderia.Rows.Add(fila);

                }
                dtDetalleEmbarque.AcceptChanges();
                this.dtgIngresoMercaderia.DataSource = dtRecepcionMercaderia;
            }
            else
                this.dtgIngresoMercaderia.DataSource = dtRecepcionMercaderia;

        }


        private void gridViewRecepcionMercaderia_ShownEditor(object sender, EventArgs e)
        {
            ColumnView view = (ColumnView)sender;

            if (view.FocusedColumn.FieldName == "IDLote" && view.ActiveEditor is SearchLookUpEdit && view.FocusedRowHandle >= 0)
            {
                SearchLookUpEdit edit = (SearchLookUpEdit)view.ActiveEditor;
                long IDProducto = (long)view.GetFocusedRowCellValue("IDProducto");
                
                edit.Properties.DataSource = CI.DAC.clsLoteDAC.GetData(-1, IDProducto, "*", "*").Tables[0];
            }
        }

        
        private void btnAgregarLotes_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionManager.BeginTran();
                DAC.clsRecepcionMercaderiaDAC.InsertUpdate("D", (int)this.IDEmbarque, -1, -1, 0, ConnectionManager.Tran);
                foreach (DataRow fila in dtRecepcionMercaderia.Rows)
                {
                    if (Convert.ToDecimal(fila["Cantidad"]) > 0)
                    {
                        DAC.clsRecepcionMercaderiaDAC.InsertUpdate("I", (int)this.IDEmbarque, (long)fila["IDProducto"], (int)fila["IDLote"], (decimal)fila["Cantidad"], ConnectionManager.Tran);
                    }
                }

                MessageBox.Show("Los datos se han guardaro correctamente");
                ConnectionManager.CommitTran();
            }
            catch (Exception ex)
            {
                ConnectionManager.RollBackTran();
                MessageBox.Show("Han ocurrido errores tratando de guardar el documento");
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionManager.BeginTran();
                int IDTransaccion = -1;
                String Asiento = "";
                DAC.clsEmbarqueDAC.CreaTransaccionInventario((int)this.IDEmbarque, (DateTime)this.dtpFecha.EditValue, ref IDTransaccion, this.sUsuario, ConnectionManager.Tran);
                CI.DAC.clsDocumentoInvCabecera.AplicaInventario(IDTransaccion, ConnectionManager.Tran);
                DAC.clsEmbarqueDAC.CreaAsientoTransaccionInventario((int)this.IDEmbarque, ref Asiento, sUsuario, ConnectionManager.Tran);
                ConnectionManager.CommitTran();

                CG.frmAsiento ofrmAsiento = new CG.frmAsiento(Asiento);
                ofrmAsiento.ShowDialog();
            }
            catch (Exception ex)
            {
                ConnectionManager.RollBackTran();
                MessageBox.Show("Han ocurrido errores tratando de aplicar el documento");
            }
        }
       

       
    }
}
