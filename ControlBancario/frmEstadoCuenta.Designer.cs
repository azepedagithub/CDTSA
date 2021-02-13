namespace ControlBancario
{
	partial class frmEstadoCuenta
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadoCuenta));
			this.slkupCuentaBancaria = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.dtpFechaInicial = new DevExpress.XtraEditors.DateEdit();
			this.dtpFechaFinal = new DevExpress.XtraEditors.DateEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.btnGenerarReporte = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.slkupCuentaBancaria.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicial.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicial.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// slkupCuentaBancaria
			// 
			this.slkupCuentaBancaria.Location = new System.Drawing.Point(128, 54);
			this.slkupCuentaBancaria.Name = "slkupCuentaBancaria";
			this.slkupCuentaBancaria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.slkupCuentaBancaria.Properties.View = this.searchLookUpEdit1View;
			this.slkupCuentaBancaria.Size = new System.Drawing.Size(281, 20);
			this.slkupCuentaBancaria.TabIndex = 0;
			// 
			// searchLookUpEdit1View
			// 
			this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
			this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// dtpFechaInicial
			// 
			this.dtpFechaInicial.EditValue = null;
			this.dtpFechaInicial.Location = new System.Drawing.Point(128, 95);
			this.dtpFechaInicial.Name = "dtpFechaInicial";
			this.dtpFechaInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFechaInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFechaInicial.Size = new System.Drawing.Size(100, 20);
			this.dtpFechaInicial.TabIndex = 1;
			// 
			// dtpFechaFinal
			// 
			this.dtpFechaFinal.EditValue = null;
			this.dtpFechaFinal.Location = new System.Drawing.Point(309, 95);
			this.dtpFechaFinal.Name = "dtpFechaFinal";
			this.dtpFechaFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpFechaFinal.Size = new System.Drawing.Size(100, 20);
			this.dtpFechaFinal.TabIndex = 1;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(39, 57);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(83, 13);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = "Cuenta Bancaria:";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(245, 98);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(58, 13);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "Fecha Final:";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(39, 98);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(63, 13);
			this.labelControl3.TabIndex = 2;
			this.labelControl3.Text = "Fecha Inicial:";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Location = new System.Drawing.Point(128, 12);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(188, 16);
			this.labelControl4.TabIndex = 2;
			this.labelControl4.Text = "Estado de Cuentas Bancarias";
			// 
			// btnGenerarReporte
			// 
			this.btnGenerarReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarReporte.Image")));
			this.btnGenerarReporte.Location = new System.Drawing.Point(161, 154);
			this.btnGenerarReporte.Name = "btnGenerarReporte";
			this.btnGenerarReporte.Size = new System.Drawing.Size(129, 23);
			this.btnGenerarReporte.TabIndex = 3;
			this.btnGenerarReporte.Text = "Generar Reporte";
			this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
			// 
			// frmEstadoCuenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 213);
			this.Controls.Add(this.btnGenerarReporte);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.dtpFechaFinal);
			this.Controls.Add(this.dtpFechaInicial);
			this.Controls.Add(this.slkupCuentaBancaria);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmEstadoCuenta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Estado de Cuenta";
			this.Load += new System.EventHandler(this.frmEstadoCuenta_Load);
			((System.ComponentModel.ISupportInitialize)(this.slkupCuentaBancaria.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicial.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicial.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SearchLookUpEdit slkupCuentaBancaria;
		private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
		private DevExpress.XtraEditors.DateEdit dtpFechaInicial;
		private DevExpress.XtraEditors.DateEdit dtpFechaFinal;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.SimpleButton btnGenerarReporte;
	}
}