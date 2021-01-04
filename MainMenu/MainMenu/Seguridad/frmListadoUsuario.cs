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
using Util;

namespace Seguridad
{
	public partial class frmListadoUsuario : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		private DataTable _dtUsuarios;
		private DataTable _dtSecurity;
		DataRow currentRow;

		string _sUsuario = (UsuarioDAC._DS.Tables.Count > 0) ? UsuarioDAC._DS.Tables[0].Rows[0]["Usuario"].ToString() : "azepeda";
		const String _tituloVentana = "Listado de Catalogos de Usuarios";
		private String _sAccion = "View";
		private String sUsuarios = "*";
		
		String Usuario, Descr,Password,Operacion;
		bool Activo;
		
		public frmListadoUsuario()
		{
			InitializeComponent();
			this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void frmCatalogoUsuario_Load(object sender, EventArgs e)
		{
			try
			{
				HabilitarControles(false);

				Util.Util.SetDefaultBehaviorControls(this.gridView1, false, this.dtgUsuarios, _tituloVentana, this);

				EnlazarEventos();

				PopulateGrid();

				CargarPrivilegios();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

	

		
		private void CargarPrivilegios()
		{
			DataSet DS = new DataSet();
			DS = UsuarioDAC.GetAccionModuloFromRole(0, _sUsuario);
			_dtSecurity = DS.Tables[0];

			AplicarPrivilegios();
		}

		private void AplicarPrivilegios()
		{
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.AgregarCentroCosto, _dtSecurity))
				this.btnAgregar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.EditarCentroCosto, _dtSecurity))
				this.btnEditar.Enabled = false;
			if (!UsuarioDAC.PermiteAccion((int)Acciones.PrivilegiosContableType.EliminarCentroCosto, _dtSecurity))
				this.btnEliminar.Enabled = false;
		}

		private void EnlazarEventos()
		{
			this.btnAgregar.ItemClick += btnAgregar_ItemClick;
			this.btnEditar.ItemClick += btnEditar_ItemClick;
			this.btnEliminar.ItemClick += btnEliminar_ItemClick;
			this.btnGuardar.ItemClick += btnGuardar_ItemClick;
			this.btnCancelar.ItemClick += btnCancelar_ItemClick;
			this.btnExportar.ItemClick += BtnExportar_ItemClick;
			this.btnRefrescar.ItemClick += btnRefrescar_ItemClick;
			this.gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
		}

		void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			PopulateGrid();
		}

		private void BtnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			string tempPath = System.IO.Path.GetTempPath();
			String FileName = System.IO.Path.Combine(tempPath, "lstPaises.xlsx");
			DevExpress.XtraPrinting.XlsxExportOptions options = new DevExpress.XtraPrinting.XlsxExportOptions()
			{
				SheetName = "Listado de Paises"
			};


			this.gridView1.ExportToXlsx(FileName, options);
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo.FileName = FileName;
			process.StartInfo.Verb = "Open";
			process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
			process.Start();
		}


		
		private void PopulateGrid()
		{
			_dtUsuarios = Security.RoleDAC.GetUsuario("*",null).Tables[0];
			this.dtgUsuarios.DataSource = null;
			this.dtgUsuarios.DataSource = _dtUsuarios;
		}

		private void ClearControls()
		{
			this.txtUsuario.Text = "";
			this.txtPassword.Text = "";
			this.txtNombre.Text = "";
			this.chkActivo.Checked  = true;
		}

		private void HabilitarControles(bool Activo)
		{
			this.chkActivo.ReadOnly = !Activo;
			this.txtNombre.ReadOnly = !Activo;
			this.txtUsuario.ReadOnly = !Activo;
			this.txtPassword.ReadOnly = !Activo;
			HabilitarBotones(Activo);
			

		}

		private void HabilitarBotones(bool Activo)
		{
			this.btnAgregar.Enabled = !Activo;
			this.btnEditar.Enabled = !Activo;
			this.btnGuardar.Enabled = Activo;
			this.btnCancelar.Enabled = Activo;
			this.btnEliminar.Enabled = !Activo;
			this.btnExportar.Enabled = !Activo;
			this.btnRefrescar.Enabled = !Activo;
			this.btnResetearPass.Enabled = !Activo;
		}

		private void SetCurrentRow()
		{
			int index = (int)this.gridView1.FocusedRowHandle;
			if (index > -1)
			{
				currentRow = gridView1.GetDataRow(index);
				UpdateControlsFromCurrentRow(currentRow);
			}
		}

		private void UpdateControlsFromCurrentRow(DataRow Row)
		{
			this.txtUsuario.EditValue = Row["Usuario"].ToString();
			this.txtNombre.EditValue = Row["Descr"].ToString();
			this.txtPassword.EditValue = Row["Password"].ToString();
			this.chkActivo.EditValue = Convert.ToBoolean(Row["Activo"]);
			
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			SetCurrentRow();
		}

		private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			_sAccion = "New";
			HabilitarControles(true);
			ClearControls();
			currentRow = null;

			this.txtUsuario.Focus();
		}

		private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (currentRow == null)
			{
				lblStatus.Caption = "Por favor seleccione un elemento de la Lista";
				return;
			}
			else
				lblStatus.Caption = "";
			
			_sAccion = "Edit";
			HabilitarControles(true);
			SetCurrentRow();
			this.txtUsuario.ReadOnly = true;
			this.txtPassword.ReadOnly = true;
			lblStatus.Caption = "Editando el registro : " + currentRow["Descr"].ToString();
			this.txtNombre.Focus();
		}


		private bool ValidarDatos()
		{
			bool result = true;
			String sMensaje = "";
			//Este solo vale para el primer elemento
			if (this.txtUsuario.Text == "")
				sMensaje = sMensaje + "     • Usuario \n\r";
			if (this.txtNombre.Text == "")
				sMensaje = sMensaje + "     • Nombre del usuario \n\r";
			if (this.txtPassword.Text == "")
				sMensaje = sMensaje + "     • Contraseña \n\r";
			
			if (sMensaje != "")
			{
				result = false;
				MessageBox.Show("Por favor revise los siguientes campos: \n\r\n\r" + sMensaje);
			}
			return result;
		}


		private void ObtenerDatos()
		{
			Usuario = this.txtUsuario.Text.Trim();
			Descr = this.txtNombre.Text.Trim();
			Password = this.txtPassword.Text.Trim();
			Activo = Convert.ToBoolean(this.chkActivo.Checked);
		}


		private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (!ValidarDatos())
					return;

				ObtenerDatos();
				

				if (_sAccion == "New")
				{
					Operacion = "I";
					Password = Security.Util.EncodePassword(Password);
				}
				else if (_sAccion=="Edit")
					Operacion = "U";
				else if(_sAccion =="ResetPass")
				{
					Operacion = "U";
					Password = Security.Util.EncodePassword(Password);
				}
				ConnectionManager.BeginTran();
				Security.RoleDAC.InsertUpdateUsuario(Operacion,Usuario,Descr,Activo,Password, ConnectionManager.Tran);
				ConnectionManager.CommitTran();

				PopulateGrid();
				ClearControls();
				HabilitarControles(false);
				if (_sAccion == "ResetPass")
				{
					this.txtPassword.Properties.PasswordChar = '•';
				}
					
				_sAccion = "View";
				this.lblStatus.Caption = "";

			}
			catch (Exception ex) {
				ConnectionManager.RollBackTran();
				MessageBox.Show("Ha ocurrido un error al momento de guardar el usuario \n\r" + ex.Message);
			}
		}

		private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			_sAccion = "View";
			HabilitarControles(false);
			AplicarPrivilegios();
			SetCurrentRow();
			lblStatus.Caption = "";
		}

		private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (this.currentRow != null )
				{
					ObtenerDatos();
					ConnectionManager.BeginTran();
					Security.RoleDAC.InsertUpdateUsuario("D", Usuario, Descr, Activo,Password, ConnectionManager.Tran);
					ConnectionManager.CommitTran();
					PopulateGrid();
					ClearControls();
					HabilitarControles(false);
					_sAccion = "View";
					this.lblStatus.Caption = "";
				}
			}
			catch (Exception ex) {
				ConnectionManager.RollBackTran();
				MessageBox.Show("Ha ocurrido un error trantado de eliminar el usuario \n\r" + ex.Message);
			}
		}

		private void btnResetearPass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.txtPassword.ReadOnly = false;
			this.txtPassword.Properties.PasswordChar = '\0';
			this.txtPassword.EditValue = "";
			
			_sAccion = "ResetPass";
			HabilitarBotones(true);
			this.txtPassword.Focus();
		}

	
		
	}
}
