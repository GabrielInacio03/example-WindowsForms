namespace exemplo_windowsForms
{
	partial class FrmCadastro
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(95, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(98, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Número";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(156, 60);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(549, 20);
			this.txtNome.TabIndex = 2;
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(156, 108);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(549, 20);
			this.txtNumero.TabIndex = 3;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(156, 169);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(549, 58);
			this.btnCalcular.TabIndex = 4;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// FrmCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1063, 450);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmCadastro";
			this.Text = "FrmCadastro";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Button btnCalcular;
	}
}