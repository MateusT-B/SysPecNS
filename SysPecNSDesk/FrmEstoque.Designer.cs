namespace SysPecNSDesk
{
    partial class FrmEstoque
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
            dataGridView1 = new DataGridView();
            clnProdutoId = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDataUltimoMovimento = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProdutoId = new TextBox();
            txtQuantidade = new TextBox();
            dtpDataUltimoMovimento = new DateTimePicker();
            btnInserir = new Button();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnProdutoId, clnQuantidade, clnDataUltimoMovimento });
            dataGridView1.Location = new Point(57, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(404, 187);
            dataGridView1.TabIndex = 0;
            // 
            // clnProdutoId
            // 
            clnProdutoId.Frozen = true;
            clnProdutoId.HeaderText = "ProdutoId";
            clnProdutoId.Name = "clnProdutoId";
            clnProdutoId.ReadOnly = true;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            // 
            // clnDataUltimoMovimento
            // 
            clnDataUltimoMovimento.Frozen = true;
            clnDataUltimoMovimento.HeaderText = "Data do ultimo movimento";
            clnDataUltimoMovimento.Name = "clnDataUltimoMovimento";
            clnDataUltimoMovimento.ReadOnly = true;
            clnDataUltimoMovimento.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 106);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "ProdutoId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 106);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 109);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 3;
            label3.Text = "Data do Ultimo Movimento";
            // 
            // txtProdutoId
            // 
            txtProdutoId.Location = new Point(57, 127);
            txtProdutoId.Name = "txtProdutoId";
            txtProdutoId.Size = new Size(100, 23);
            txtProdutoId.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(201, 127);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 5;
            // 
            // dtpDataUltimoMovimento
            // 
            dtpDataUltimoMovimento.Format = DateTimePickerFormat.Short;
            dtpDataUltimoMovimento.Location = new Point(340, 127);
            dtpDataUltimoMovimento.Name = "dtpDataUltimoMovimento";
            dtpDataUltimoMovimento.Size = new Size(121, 23);
            dtpDataUltimoMovimento.TabIndex = 6;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(495, 245);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(495, 316);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "&Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 450);
            Controls.Add(btnAtualizar);
            Controls.Add(btnInserir);
            Controls.Add(dtpDataUltimoMovimento);
            Controls.Add(txtQuantidade);
            Controls.Add(txtProdutoId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmEstoque";
            Text = "FrmEstoque";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clnProdutoId;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDataUltimoMovimento;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProdutoId;
        private TextBox txtQuantidade;
        private DateTimePicker dtpDataUltimoMovimento;
        private Button btnInserir;
        private Button btnAtualizar;
    }
}