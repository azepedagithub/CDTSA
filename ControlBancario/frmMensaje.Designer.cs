namespace ControlBancario
{
	partial class frmMensaje
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
			this.txtMensaje = new System.Windows.Forms.RichTextBox();
			this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
			this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.SuspendLayout();
			// 
			// txtMensaje
			// 
			this.txtMensaje.Location = new System.Drawing.Point(2, 31);
			this.txtMensaje.Name = "txtMensaje";
			this.txtMensaje.Size = new System.Drawing.Size(496, 121);
			this.txtMensaje.TabIndex = 0;
			this.txtMensaje.Text = "";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(342, 158);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 1;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(423, 158);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 1;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(12, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(94, 13);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = "Notas de la cuenta:";
			// 
			// frmMensaje
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 189);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.txtMensaje);
			this.Name = "frmMensaje";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mensaje";
			this.Load += new System.EventHandler(this.frmMensaje_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox txtMensaje;
		private DevExpress.XtraEditors.SimpleButton btnCancelar;
		private DevExpress.XtraEditors.SimpleButton btnGuardar;
		private DevExpress.XtraEditors.LabelControl labelControl1;

	}
}