namespace SysPecNSDesk
{
    partial class frmProduto
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
            helpProvider1 = new HelpProvider();
            gbProdutos = new GroupBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            label9 = new Label();
            txtDesconto = new TextBox();
            label8 = new Label();
            txtDesc = new TextBox();
            label7 = new Label();
            cmbCategoria = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            nudEstoqueMin = new NumericUpDown();
            txtUnidVenda = new TextBox();
            txtValUnit = new TextBox();
            label4 = new Label();
            txtCodBarras = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            dgvProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCodBarras = new DataGridViewTextBoxColumn();
            clnDesc = new DataGridViewTextBoxColumn();
            clnValUnit = new DataGridViewTextBoxColumn();
            clnUnidVenda = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoqueMin = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnDataCad = new DataGridViewTextBoxColumn();
            label1 = new Label();
            gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // gbProdutos
            // 
            gbProdutos.Controls.Add(btnConsultar);
            gbProdutos.Controls.Add(btnEditar);
            gbProdutos.Controls.Add(btnAdicionar);
            gbProdutos.Controls.Add(label9);
            gbProdutos.Controls.Add(txtDesconto);
            gbProdutos.Controls.Add(label8);
            gbProdutos.Controls.Add(txtDesc);
            gbProdutos.Controls.Add(label7);
            gbProdutos.Controls.Add(cmbCategoria);
            gbProdutos.Controls.Add(label6);
            gbProdutos.Controls.Add(label5);
            gbProdutos.Controls.Add(nudEstoqueMin);
            gbProdutos.Controls.Add(txtUnidVenda);
            gbProdutos.Controls.Add(txtValUnit);
            gbProdutos.Controls.Add(label4);
            gbProdutos.Controls.Add(txtCodBarras);
            gbProdutos.Controls.Add(label3);
            gbProdutos.Controls.Add(txtId);
            gbProdutos.Controls.Add(label2);
            gbProdutos.Location = new Point(97, 43);
            gbProdutos.Name = "gbProdutos";
            gbProdutos.Size = new Size(706, 312);
            gbProdutos.TabIndex = 0;
            gbProdutos.TabStop = false;
            gbProdutos.Text = "Produtos";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(420, 239);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 18;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(303, 239);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(178, 239);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 16;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 221);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 15;
            label9.Text = "Desconto";
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(40, 239);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(107, 23);
            txtDesconto.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(229, 164);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 13;
            label8.Text = "Categoria";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(40, 182);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(161, 23);
            txtDesc.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 164);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 11;
            label7.Text = "Descrição";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(229, 182);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(410, 23);
            cmbCategoria.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(534, 103);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 9;
            label6.Text = "Estoque Mínimo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(378, 103);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 8;
            label5.Text = "Unidade de Venda";
            // 
            // nudEstoqueMin
            // 
            nudEstoqueMin.Location = new Point(534, 121);
            nudEstoqueMin.Name = "nudEstoqueMin";
            nudEstoqueMin.Size = new Size(33, 23);
            nudEstoqueMin.TabIndex = 7;
            // 
            // txtUnidVenda
            // 
            txtUnidVenda.Location = new Point(367, 121);
            txtUnidVenda.Name = "txtUnidVenda";
            txtUnidVenda.PlaceholderText = "EX:Caixa";
            txtUnidVenda.Size = new Size(128, 23);
            txtUnidVenda.TabIndex = 6;
            // 
            // txtValUnit
            // 
            txtValUnit.Location = new Point(209, 121);
            txtValUnit.Name = "txtValUnit";
            txtValUnit.Size = new Size(121, 23);
            txtValUnit.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 103);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 4;
            label4.Text = "Valor Unitário";
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(40, 121);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(128, 23);
            txtCodBarras.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 103);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Código de barras";
            // 
            // txtId
            // 
            txtId.Location = new Point(40, 61);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(70, 23);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 43);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodBarras, clnDesc, clnValUnit, clnUnidVenda, clnCategoria, clnEstoqueMin, clnDesconto, clnDataCad });
            dgvProdutos.Location = new Point(97, 387);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.Size = new Size(706, 178);
            dgvProdutos.TabIndex = 1;
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnCodBarras
            // 
            clnCodBarras.HeaderText = "Código de Barras";
            clnCodBarras.Name = "clnCodBarras";
            clnCodBarras.ReadOnly = true;
            clnCodBarras.Width = 130;
            // 
            // clnDesc
            // 
            clnDesc.HeaderText = "Descrição";
            clnDesc.Name = "clnDesc";
            clnDesc.ReadOnly = true;
            // 
            // clnValUnit
            // 
            clnValUnit.HeaderText = "Valor Unitário";
            clnValUnit.Name = "clnValUnit";
            clnValUnit.ReadOnly = true;
            clnValUnit.Width = 125;
            // 
            // clnUnidVenda
            // 
            clnUnidVenda.HeaderText = "Unidade de Venda";
            clnUnidVenda.Name = "clnUnidVenda";
            clnUnidVenda.ReadOnly = true;
            clnUnidVenda.Width = 140;
            // 
            // clnCategoria
            // 
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            // 
            // clnEstoqueMin
            // 
            clnEstoqueMin.HeaderText = "Estoque Minímo";
            clnEstoqueMin.Name = "clnEstoqueMin";
            clnEstoqueMin.ReadOnly = true;
            clnEstoqueMin.Width = 140;
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            // 
            // clnDataCad
            // 
            clnDataCad.HeaderText = "Data Cadastro";
            clnDataCad.Name = "clnDataCad";
            clnDataCad.ReadOnly = true;
            clnDataCad.Width = 130;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(342, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 40);
            label1.TabIndex = 2;
            label1.Text = "PRODUTOS";
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 604);
            Controls.Add(label1);
            Controls.Add(dgvProdutos);
            Controls.Add(gbProdutos);
            Name = "frmProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProduto";
            Load += frmProduto_Load;
            gbProdutos.ResumeLayout(false);
            gbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HelpProvider helpProvider1;
        private GroupBox gbProdutos;
        private DataGridView dgvProdutos;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private Label label7;
        private ComboBox cmbCategoria;
        private Label label6;
        private Label label5;
        private NumericUpDown nudEstoqueMin;
        private TextBox txtUnidVenda;
        private TextBox txtValUnit;
        private Label label4;
        private TextBox txtCodBarras;
        private Label label3;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnAdicionar;
        private Label label9;
        private TextBox txtDesconto;
        private Label label8;
        private TextBox txtDesc;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodBarras;
        private DataGridViewTextBoxColumn clnDesc;
        private DataGridViewTextBoxColumn clnValUnit;
        private DataGridViewTextBoxColumn clnUnidVenda;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoqueMin;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDataCad;
    }
}