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
    public partial class FrmClienteNovo : Form
    {
        public FrmClienteNovo()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(
                txtNome.Text,
                txtEmail.Text,
                txtCpf.Text,
                txtTelefone.Text,
                dtpDataDeNascimento.Value,
                dtpDataCadastro.Value
                 );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                txtIdCliente.Text = cliente.Id.ToString();
                MessageBox.Show($"O cliente {cliente.Nome}, " +
                    $"foi inserido com sucesso, com o ID - {cliente.Id}");
                txtIdCliente.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtCpf.Clear();
                txtTelefone.Clear();

            }
            else
            {
                MessageBox.Show("Falha ao inserir o cliente");
            }
        }

        private void btnInserirEndereço_Click(object sender, EventArgs e)
        {
            Endereco endereco = new(
                 Cliente.ObterPorId(int.Parse(txtIdEndereco.Text)),
                 txtCep.Text,
                 txtLogradouro.Text,
                 txtNumero.Text,
                 txtComplemento.Text,
                 txtBairro.Text,
                 txtCidade.Text,
                 cmbUf.Text,
                 cmbTipoEndereco.Text
                );
            endereco.Inserir();
            if (endereco.Id > 0)
            {
                txtIdEndereco.Text = endereco.Id.ToString();
                MessageBox.Show($"O Endereço foi cadastro com sucesso");
                txtCep.Clear();
                txtLogradouro.Clear();
                txtNumero.Clear();
                txtComplemento.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
            }
            else
            {
                MessageBox.Show("Falha ao inserir o endereço");
            }
        }
    }
}
