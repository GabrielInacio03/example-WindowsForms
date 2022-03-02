﻿using System;
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
            txtNome.Text = "Olá Inácio";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new FrmShow();
            form.lblMensagem.Text = txtNome.Text;
            form.Show(); //abre uma nova instância do objeto
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
