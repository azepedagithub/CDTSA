using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Security;
using DevExpress.XtraGrid.Views.Grid;

namespace Seguridad
{
	public partial class frmRoles : Form
	{
		List<clsAcciones> lstAcciones = new List<clsAcciones>();
		List<clsAcciones> lstAccionesSeleccionadas = new List<clsAcciones>();

		DataTable dtAccionesSeleccionadas = new DataTable();
		DataTable dtRoles = new DataTable();
		bool isEditing = false;
		private DataRow CurrentRowRole;

		public frmRoles()
		{
			InitializeComponent();
		}


		private void CargarAcciones() {
			DataTable dtAcciones = RoleDAC.GetArbolAcciones().Tables[0];
			lstAcciones = new List<clsAcciones>();

			foreach (DataRow row in dtAcciones.Rows)
			{
				clsAcciones det = new clsAcciones()
				{
					IDModulo = Convert.ToInt32(row["IDModulo"]),
					IDAccion = Convert.ToInt32(row["IDAccion"]),
					DescrModulo = row["DescrModulo"].ToString(),
					DescrAccion = row["Descr"].ToString()
				};
				lstAcciones.Add(det);
			}

			this.dtgAcciones.DataSource = lstAcciones;
			
		}

		private void ConfigurarGrilla() {
			gridViewAcciones.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
			gridViewAcciones.OptionsView.ShowGroupedColumns = true;
			gridViewAcciones.OptionsView.ShowGroupPanel = false;
			this.gridViewAcciones.OptionsBehavior.AutoExpandAllGroups = true;
			//this.gridViewAcciones.OptionsView.AllowCellMerge = true;
			this.gridViewAcciones.OptionsView.ShowGroupPanel = false;
			this.gridViewAcciones.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
			this.gridViewAcciones.OptionsSelection.ShowCheckBoxSelectorInGroupRow  = DevExpress.Utils.DefaultBoolean.True;
			this.gridViewAcciones.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
			this.gridViewAcciones.OptionsSelection.MultiSelect = true;
		}

		private void frmRoles_Load(object sender, EventArgs e)
		{
			ConfigurarGrilla();
			DeshabilitarControles();
			CargarRoles();
			//if (dtRoles.Rows.Count>0)
			CargarAcciones();
			SetCurrentRowRole();
		}

		private void CargarRoles() {
			dtRoles = RoleDAC.GetRole(-1).Tables[0];
			this.dtgRoles.DataSource = dtRoles;
		}

		private void DeshabilitarControles()
		{
			this.btnAdd.Enabled = true;
			this.btnEdit.Enabled = true;
			this.btnDelete.Enabled = true;
			this.btnCancelar.Enabled = false;
			this.btnGuardar.Enabled = false;

			this.txtDescr.ReadOnly = true;
			this.txtDescrLarga.ReadOnly = true;
			this.dtgRoles.Enabled = true;
			this.gridViewAcciones.OptionsBehavior.ReadOnly = true;
		}

		private void HabilitarControles() {
			this.btnAdd.Enabled = false;
			this.btnEdit.Enabled = false;
			this.btnDelete.Enabled = false;
			this.btnCancelar.Enabled = true;
			this.btnGuardar.Enabled = true;

			this.txtDescr.ReadOnly = false;
			this.txtDescrLarga.ReadOnly = false;
			this.dtgRoles.Enabled = false;
			this.gridViewAcciones.OptionsBehavior.ReadOnly = false;
		}



		private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.CurrentRowRole = null;
			HabilitarControles();
			CargarAcciones();
			this.txtDescr.EditValue = "";
			this.txtDescrLarga.EditValue = "";
			isEditing = true;
		}


		private void SetCurrentRowRole()
		{
			int index = (int)this.gridView2.FocusedRowHandle;
			if (index > -1)
			{
				CurrentRowRole = gridView2.GetDataRow(index);
				UpdateControlsFromCurrentRowRole(CurrentRowRole);
			}
		}

		private void UpdateControlsFromCurrentRowRole(DataRow Row)
		{
			try
			{
				this.txtDescr.Text = Row["Descr"].ToString();
				this.txtDescrLarga.Text = Row["DescrLarga"].ToString();
				if (this.dtRoles.Rows.Count > 0)
				{
					DataTable dt = Security.RoleDAC.GetAccionesByRole(Convert.ToInt32(Row["IDRole"])).Tables[0];
					int CountGroup = this.gridViewAcciones.GroupCount + 1;
					this.gridViewAcciones.ClearSelection();
					foreach (DataRow fila in dt.Rows)
					{
						for (int i = 0; i < this.gridViewAcciones.RowCount - CountGroup; i++)
						{
							if (this.gridViewAcciones.GetRowCellValue(i, "IDAccion").ToString() == fila["IDAccion"].ToString())
								gridViewAcciones.SelectRow(i);
						}
					}
				}
			}
			catch (Exception ex) {
				MessageBox.Show("Han ocurrido los siguientes errores: " + ex.Message);
			}
			
		}

		private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			SetCurrentRowRole();
		}

		private bool ValidarControles() {
			//validar los controles
			String sMensaje = "";
			if (this.txtDescr.EditValue == null || this.txtDescr.EditValue.ToString().Trim() == "")
				sMensaje = " • Establezaca una descripción para el role \n\r";
			if (this.txtDescrLarga.EditValue == null  || this.txtDescrLarga.EditValue.ToString().Trim() == "")
				sMensaje = sMensaje + "	• Establezca una descripción mas detallada para el role \n\r";
			
			if (gridViewAcciones.GetSelectedRows().Count() == 0) {
				sMensaje = sMensaje + "	• Seleccione al menos una accion para el role";
			}
			
			if (sMensaje != "")
			{
				MessageBox.Show("Por favor verifique los siguientes campos: \n\r" + sMensaje);
				return false;
			}
			else
				return true;
		}

		private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			int IDRole = -1;
			try
			{
				if (ValidarControles())
				{
					//Proceder a borrar los privilegios anteriores
					Security.ConnectionManager.BeginTran();
					if (CurrentRowRole != null)
					{
						IDRole = Convert.ToInt32(CurrentRowRole["IDRole"]);
						RoleDAC.InsertUpdateRoleAccion("D", -1, IDRole, -1, Security.ConnectionManager.Tran);
						RoleDAC.InsertUpdateRole("U", ref IDRole, this.txtDescr.Text.Trim(), this.txtDescrLarga.Text.Trim(), Security.ConnectionManager.Tran);
					}
					else
						RoleDAC.InsertUpdateRole("I", ref IDRole, this.txtDescr.Text.Trim(), this.txtDescrLarga.Text.Trim(), Security.ConnectionManager.Tran);

					int[] filasSeleccionadas = this.gridViewAcciones.GetSelectedRows();
					foreach (int i in filasSeleccionadas)
					{
						int IDAccion = Convert.ToInt32(gridViewAcciones.GetRowCellValue(i, "IDAccion"));
						int IDModulo = Convert.ToInt32(this.gridViewAcciones.GetRowCellValue(i, "IDModulo"));
						//Insertar en Tabla
						RoleDAC.InsertUpdateRoleAccion("I", IDModulo, IDRole, IDAccion, Security.ConnectionManager.Tran);
					}
					MessageBox.Show("El role ha sido guardardo con Exito");
					Security.ConnectionManager.CommitTran();
					isEditing = false;
					CargarRoles();
					if (this.dtRoles.Rows.Count > 0)
						CargarAcciones();
					SetCurrentRowRole();
					DeshabilitarControles();
				}
			}
			catch (Exception ex) {
				MessageBox.Show("Han ocurrido los siguientes errores : " + ex.Message);
				if (ConnectionManager.Tran != null)
					ConnectionManager.RollBackTran();
			}
		}

		private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			HabilitarControles();
			isEditing = true;
		}

		private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			DeshabilitarControles();
			CargarRoles();
			isEditing = false;
		}

		private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (MessageBox.Show("Esta seguro de eliminar el role?", "Administración de Usuarios", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
				{
					int IDRole = Convert.ToInt32(CurrentRowRole["IDRole"]);
					Security.ConnectionManager.BeginTran();
					RoleDAC.InsertUpdateRole("D", ref IDRole, "", "", Security.ConnectionManager.Tran);
					Security.ConnectionManager.CommitTran();
					MessageBox.Show("El role se ha eliminado con exito");
					CargarRoles();
					SetCurrentRowRole();
				}
			}
			catch (Exception ex) {
				MessageBox.Show("Han ocurrido los siguientes errores: " + ex.Message);
				if (ConnectionManager.Tran != null)
					ConnectionManager.RollBackTran();
			}
		}

		private void gridViewAcciones_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			MessageBox.Show("Paso");
		}

		


		 //foreach (SucursalVendedor suc in lstSucursalVendedor.Where(a=>a.Seleccionado==true))
		 //   {

		 //	   Task TaskAplicarRolling = new Task(new Action(() => AplicarRolling(suc.IDRolling, suc.IDTipoRolling, suc.CodSucursal, suc.CodVendedor)));
		 //	   TaskAplicarRolling.Start();
		 //   }

		 //   MessageBox.Show("El rolling se ha aplicado con éxito!!");
		 //   //this.Close();
		 //   CargarDatos();
	}

	public class clsAcciones
	{
		public int IDAccion { get; set; }
		public int IDModulo { get; set; }
		public String DescrModulo { get; set; }
		public String DescrAccion { get; set; }
		public bool Seleccionado { get; set; }

		public clsAcciones()
		{
			IDAccion = -1;
			IDModulo = -1;
			DescrAccion = "";
			DescrModulo = "";
			Seleccionado = false;
		}
	}
}
