using SysPecNSLib;
using System;
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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            var categoria = Categoria.ObterLista();
            cmbCategoria.DataSource = categoria;
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DisplayMember = "Nome";

            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int count = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[count].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[count].Cells[1].Value = produto.CodBar;
                dgvProdutos.Rows[count].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[count].Cells[3].Value = produto.ValorUnit;
                dgvProdutos.Rows[count].Cells[4].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[count].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[count].Cells[6].Value = produto.EstoqueMinimo;
                dgvProdutos.Rows[count].Cells[7].Value = produto.ClasseDesconto;
                dgvProdutos.Rows[count].Cells[8].Value = produto.DataCad;



                count++;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new(txtCodBarras.Text, txtDesc.Text,
                double.Parse(txtValUnit.Text), txtUnidVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (int)nudEstoqueMin.Value, double.Parse(txtDesconto.Text)

                );
            produto.Inserir();
            if (produto.Id > 0)
            {
                MessageBox.Show($"Produto gravado com sucesso o ID{produto.Id}");
                frmProduto_Load(sender, e);
            }



        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                txtCodBarras.Clear();
                txtValUnit.Clear();
                txtUnidVenda.Clear();
                txtDesc.Clear();
                txtDesconto.Clear();
                nudEstoqueMin.Value = 0;
                btnConsultar.Text = "&Obter por ID";
                txtId.Focus();
                txtId.ReadOnly = false;

            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Produto produto = Produto.ObterPorId(int.Parse(txtId.Text));
                    txtCodBarras.Text = produto.CodBar;
                    txtValUnit.Text = Convert.ToString(produto.ValorUnit);
                    txtDesc.Text = produto.Descricao;
                    txtDesconto.Text = produto.ClasseDesconto.ToString();
                    txtUnidVenda.Text = produto.UnidadeVenda;
                    //nudEstoqueMin.Value = produto.EstoqueMinimo;
                    cmbCategoria.SelectedIndex =
                        cmbCategoria.FindString(produto.Categoria.Nome);
                    btnEditar.Enabled = true;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new(int.Parse(txtId.Text),
                txtCodBarras.Text,
                txtDesc.Text,
                double.Parse(txtValUnit.Text),
                txtUnidVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (double)nudEstoqueMin.Value,
                double.Parse(txtDesconto.Text)
                );
            produto.Atualizar();// grava as alterações no banco
            MessageBox.Show($"Produto {produto.Descricao} atualizado com sucesso!");
            btnEditar.Enabled = false;
            txtId.ReadOnly = true;
            btnConsultar.Text = "&Consultar";
            LimpaControles();
            frmProduto_Load(sender, e);

        }
        private void LimpaControles()
        {
            txtCodBarras.Clear();
            txtValUnit.Clear();
            txtUnidVenda.Clear();
            txtDesc.Clear();
            txtDesconto.Clear();
        }

    }
}
