namespace CG
{
	partial class frmGenerarDocumentosCierrePeriodoFiscal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerarDocumentosCierrePeriodoFiscal));
			this.txtPeriodo = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.btnGenerarDocumento = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPeriodo
			// 
			this.txtPeriodo.Location = new System.Drawing.Point(87, 58);
			this.txtPeriodo.Name = "txtPeriodo";
			this.txtPeriodo.Size = new System.Drawing.Size(100, 20);
			this.txtPeriodo.TabIndex = 0;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(40, 61);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(40, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Periodo:";
			// 
			// btnGenerarDocumento
			// 
			this.btnGenerarDocumento.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarDocumento.Image")));
			this.btnGenerarDocumento.Location = new System.Drawing.Point(251, 56);
			this.btnGenerarDocumento.Name = "btnGenerarDocumento";
			this.btnGenerarDocumento.Size = new System.Drawing.Size(140, 23);
			this.btnGenerarDocumento.TabIndex = 2;
			this.btnGenerarDocumento.Text = "Generar Documentos";
			// 
			// labelControl2
			// 
			this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
			this.labelControl2.Location = new System.Drawing.Point(12, 12);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(398, 26);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Este proceso genera una asiento contable de cierre del periodo, por favor verific" +
    "ar luego de ganerar el proceso.";
			this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
			// 
			// frmGenerarDocumentosCierrePeriodoFiscal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 114);
			this.Controls.Add(this.btnGenerarDocumento);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.txtPeriodo);
			this.Name = "frmGenerarDocumentosCierrePeriodoFiscal";
			this.Text = "Generación de Documentos del Periodo 13";
			this.Load += new System.EventHandler(this.frmGenerarDocumentosCierrePeriodoFiscal_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit txtPeriodo;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.SimpleButton btnGenerarDocumento;
		private DevExpress.XtraEditors.LabelControl labelControl2;
	}
}