namespace exemplo_windowsForms
{
	partial class FrmLicenca
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
			this.btnObter = new System.Windows.Forms.Button();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.txtChaveLicenca = new System.Windows.Forms.TextBox();
			this.lblChaveLicenca = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnObter
			// 
			this.btnObter.Location = new System.Drawing.Point(12, 12);
			this.btnObter.Name = "btnObter";
			this.btnObter.Size = new System.Drawing.Size(106, 31);
			this.btnObter.TabIndex = 0;
			this.btnObter.Text = "ObterLicenca";
			this.btnObter.UseVisualStyleBackColor = true;
			this.btnObter.Click += new System.EventHandler(this.btnObter_Click);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Location = new System.Drawing.Point(391, 89);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
			this.btnRegistrar.TabIndex = 1;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// txtChaveLicenca
			// 
			this.txtChaveLicenca.Location = new System.Drawing.Point(12, 92);
			this.txtChaveLicenca.Name = "txtChaveLicenca";
			this.txtChaveLicenca.Size = new System.Drawing.Size(373, 20);
			this.txtChaveLicenca.TabIndex = 2;
			// 
			// lblChaveLicenca
			// 
			this.lblChaveLicenca.AutoSize = true;
			this.lblChaveLicenca.Location = new System.Drawing.Point(13, 73);
			this.lblChaveLicenca.Name = "lblChaveLicenca";
			this.lblChaveLicenca.Size = new System.Drawing.Size(94, 13);
			this.lblChaveLicenca.TabIndex = 3;
			this.lblChaveLicenca.Text = "Chave da Licença";
			// 
			// FrmLicenca
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblChaveLicenca);
			this.Controls.Add(this.txtChaveLicenca);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.btnObter);
			this.Name = "FrmLicenca";
			this.Text = "FrmLicenca";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnObter;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.TextBox txtChaveLicenca;
		private System.Windows.Forms.Label lblChaveLicenca;
	}
}