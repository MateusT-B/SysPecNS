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
    public partial class FrmEstoque : Form
    {
        Produto produto;
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Estoque estoque = new(
                Convert.ToInt32(txtProdutoId.Text),
                Convert.ToDouble(txtQuantidade.Text),
                dtpDataUltimoMovimento.Value = DateTime.Now
                );

        }

    }
}
