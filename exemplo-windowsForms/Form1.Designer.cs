
namespace exemplo_windowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.btnOk = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.btnAbrir = new System.Windows.Forms.Button();
			this.ddlEstado = new System.Windows.Forms.ComboBox();
			this.lblEstados = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.novoTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.licençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.doaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblHora = new System.Windows.Forms.Label();
			this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.btnOk.Location = new System.Drawing.Point(601, 333);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "Click";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.label1.Location = new System.Drawing.Point(12, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Preencha:";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(16, 54);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(269, 20);
			this.txtNome.TabIndex = 2;
			// 
			// btnAbrir
			// 
			this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAbrir.Location = new System.Drawing.Point(682, 333);
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Size = new System.Drawing.Size(111, 23);
			this.btnAbrir.TabIndex = 3;
			this.btnAbrir.Text = "Abrir nova janela";
			this.btnAbrir.UseVisualStyleBackColor = true;
			this.btnAbrir.Click += new System.EventHandler(this.button1_Click);
			// 
			// ddlEstado
			// 
			this.ddlEstado.FormattingEnabled = true;
			this.ddlEstado.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Minas Gerais"});
			this.ddlEstado.Location = new System.Drawing.Point(328, 54);
			this.ddlEstado.Name = "ddlEstado";
			this.ddlEstado.Size = new System.Drawing.Size(155, 21);
			this.ddlEstado.TabIndex = 4;
			this.ddlEstado.Text = "Selecione um Estado";
			// 
			// lblEstados
			// 
			this.lblEstados.AutoSize = true;
			this.lblEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstados.Location = new System.Drawing.Point(324, 31);
			this.lblEstados.Name = "lblEstados";
			this.lblEstados.Size = new System.Drawing.Size(68, 20);
			this.lblEstados.TabIndex = 5;
			this.lblEstados.Text = "Estados";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(16, 161);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(467, 150);
			this.dataGridView1.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "DataGridView";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.cadastroToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// arquivoToolStripMenuItem
			// 
			this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoTextoToolStripMenuItem,
            this.sairToolStripMenuItem});
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.arquivoToolStripMenuItem.Text = "Arquivo";
			// 
			// novoTextoToolStripMenuItem
			// 
			this.novoTextoToolStripMenuItem.Name = "novoTextoToolStripMenuItem";
			this.novoTextoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.novoTextoToolStripMenuItem.Text = "Novo Texto";
			this.novoTextoToolStripMenuItem.Click += new System.EventHandler(this.novoTextoToolStripMenuItem_Click);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.licençaToolStripMenuItem,
            this.doaçãoToolStripMenuItem});
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.infoToolStripMenuItem.Text = "Info";
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.sobreToolStripMenuItem.Text = "Sobre";
			this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
			// 
			// licençaToolStripMenuItem
			// 
			this.licençaToolStripMenuItem.Name = "licençaToolStripMenuItem";
			this.licençaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.licençaToolStripMenuItem.Text = "Licença";
			this.licençaToolStripMenuItem.Click += new System.EventHandler(this.licençaToolStripMenuItem_Click);
			// 
			// doaçãoToolStripMenuItem
			// 
			this.doaçãoToolStripMenuItem.Name = "doaçãoToolStripMenuItem";
			this.doaçãoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.doaçãoToolStripMenuItem.Text = "Doação";
			this.doaçãoToolStripMenuItem.Click += new System.EventHandler(this.doaçãoToolStripMenuItem_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblHora
			// 
			this.lblHora.AutoSize = true;
			this.lblHora.Location = new System.Drawing.Point(589, 54);
			this.lblHora.Name = "lblHora";
			this.lblHora.Size = new System.Drawing.Size(57, 13);
			this.lblHora.TabIndex = 9;
			this.lblHora.Text = "Hora Atual";
			// 
			// cadastroToolStripMenuItem
			// 
			this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
			this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.cadastroToolStripMenuItem.Text = "Cadastro";
			this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 368);
			this.Controls.Add(this.lblHora);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lblEstados);
			this.Controls.Add(this.ddlEstado);
			this.Controls.Add(this.btnAbrir);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Aplicação WindowsForms .Net Framework";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ComboBox ddlEstado;
        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem novoTextoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem licençaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem doaçãoToolStripMenuItem;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblHora;
		private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
	}
}

