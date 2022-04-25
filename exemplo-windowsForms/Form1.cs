using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_windowsForms
{   
    public partial class Form1 : Form
    {          
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtNome.Text = "Olá "+ ddlEstado.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new FrmShow();
            form.lblMensagem.Text = txtNome.Text;
            form.Show(); //abre uma nova instância do objeto
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			AtualizarDataHora();
			ddlEstado.DataSource = Estado.Lista();
            ddlEstado.Text = "[Selecione]";

			//Exemplo 1 de exibição
			/*
			ddlEstado.Items.Clear();
			foreach (var item in Estado.Lista())
			{
				ddlEstado.Items.Add(item);
			}
			*/

			//Exemplo 2 de exibição
			/*
			dataGridView1.DataSource = Estado.Lista();
			*/

			//Exemplo 3 de exibição
			dataGridView1.ColumnCount = 2;
			
			dataGridView1.Columns[0].Name = "Id";
			dataGridView1.Columns[1].Name = "Nome";

			var linhas = new List<string[]>();
			foreach(Estado estado in Estado.Lista())
			{
				string[] linha1 = new string[] { estado.Id.ToString(), estado.Nome};
				linhas.Add(linha1);
			}
			foreach (string[] linhaArray in linhas)
			{
				dataGridView1.Rows.Add(linhaArray);
			}
			

			//Exemplo 4 de exibição com LINK
			//var data = from estado in Estado.Lista()
			//	orderby estado.Nome
			//		select new
			//		{
			//			Id = estado.Id,
			//			Nome = estado.Nome
			//		};
			//dataGridView1.DataSource = data.ToString();
        }

		private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmTexto().Show();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmSobre().Show();
		}

		private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmLicenca().Show();
		}

		private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmDoacao().Show();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			AtualizarDataHora();
		}

		private void AtualizarDataHora()
		{
			lblHora.Text = "Dia e Hora atual " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
		}
	}
}
