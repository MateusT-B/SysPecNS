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
                 txtLogradouro.Text,
                 txtCep.Text,
                 txtNumero.Text,
                 cmbUf.Text,
                 txtCidade.Text,
                 txtComplemento.Text,
                 txtBairro.Text,
                 cmbTipoEndereco.Text
                );
            endereco.Inserir();
            if (endereco.Id>0)
            {
                txtIdEndereco.Text = endereco.Id.ToString();
                MessageBox.Show($"O Endereço foi cadastro com sucesso");
                txtLogradouro.Clear();
                txtCep.Clear();
                txtNumero.Clear();
                txtCidade.Clear();
                txtComplemento.Clear();
                txtBairro.Clear();
            }
            else
            {
                MessageBox.Show("Falha ao inserir o endereço");
            }
        }
    }
}
