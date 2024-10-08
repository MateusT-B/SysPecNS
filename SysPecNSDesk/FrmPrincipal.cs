﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var msg = MessageBox.Show("Deseja Sair?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (msg == DialogResult.Yes) Application.Exit();

        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduto frmProduto = new();
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new();
            frmLogin.ShowDialog();
            Text += $" ({Program.UsuarioLogado.Email})";
            toolStripStatusLabel1.Text = $"{Program.UsuarioLogado.Nome} - {Program.UsuarioLogado.Nivel.Nome}";
        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPedidoNovo frmPedidoNovo = new();
            frmPedidoNovo.MdiParent = this;
            frmPedidoNovo.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteNovo frmcliente = new();
            frmcliente.MdiParent = this;
            frmcliente.Show();
        }

        private void controleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstoque frmestoque = new();
            frmestoque.MdiParent = this;
            frmestoque.Show();
        }
    }
}
