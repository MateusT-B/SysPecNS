namespace SysPecNSDesk
{
    partial class FrmPedidoNovo
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
            grbIdentificacao = new GroupBox();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            label5 = new Label();
            txtCliente = new TextBox();
            txtUsuario = new TextBox();
            label4 = new Label();
            label3 = new Label();
            grbItens = new GroupBox();
            textBox1 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            txtDescontoItem = new TextBox();
            label9 = new Label();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            label8 = new Label();
            txtDescricao = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtCodBar = new TextBox();
            brnAddItem = new Button();
            dgvItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtIdPedido = new TextBox();
            textBox2 = new TextBox();
            txtDescontoPedido = new TextBox();
            txtDescontoItens = new TextBox();
            btnFechar = new Button();
            txtSubTotal = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            grbIdentificacao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIdentificacao
            // 
            grbIdentificacao.Controls.Add(btnInserePedido);
            grbIdentificacao.Controls.Add(txtIdCliente);
            grbIdentificacao.Controls.Add(label5);
            grbIdentificacao.Controls.Add(txtCliente);
            grbIdentificacao.Controls.Add(txtUsuario);
            grbIdentificacao.Controls.Add(label4);
            grbIdentificacao.Controls.Add(label3);
            grbIdentificacao.Location = new Point(47, 56);
            grbIdentificacao.Name = "grbIdentificacao";
            grbIdentificacao.Size = new Size(540, 165);
            grbIdentificacao.TabIndex = 0;
            grbIdentificacao.TabStop = false;
            grbIdentificacao.Text = "Identificação";
            // 
            // btnInserePedido
            // 
            btnInserePedido.Location = new Point(364, 53);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(75, 43);
            btnInserePedido.TabIndex = 1;
            btnInserePedido.Text = "&Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click_1;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(79, 87);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(65, 23);
            txtIdCliente.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 90);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "&Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(150, 87);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(198, 23);
            txtCliente.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(79, 41);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(269, 23);
            txtUsuario.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 44);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 44);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "&Usuário";
            // 
            // grbItens
            // 
            grbItens.Controls.Add(textBox1);
            grbItens.Controls.Add(label11);
            grbItens.Controls.Add(label10);
            grbItens.Controls.Add(txtDescontoItem);
            grbItens.Controls.Add(label9);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(txtCodBar);
            grbItens.Controls.Add(brnAddItem);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Enabled = false;
            grbItens.Location = new Point(47, 254);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(642, 359);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens de Pedido";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(515, 312);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 33);
            textBox1.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(449, 318);
            label11.Name = "label11";
            label11.Size = new Size(71, 21);
            label11.TabIndex = 16;
            label11.Text = "Total R$";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(463, 36);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 15;
            label10.Text = "Desconto";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(454, 58);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.RightToLeft = RightToLeft.Yes;
            txtDescontoItem.Size = new Size(86, 23);
            txtDescontoItem.TabIndex = 4;
            txtDescontoItem.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(396, 36);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 13;
            label9.Text = "Quant.";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(378, 58);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.RightToLeft = RightToLeft.Yes;
            txtQuantidade.Size = new Size(70, 23);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.Text = "0";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(280, 58);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(92, 23);
            txtValorUnit.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(299, 36);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 10;
            label8.Text = "Valor Unit";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(174, 58);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(100, 23);
            txtDescricao.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(194, 36);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 8;
            label7.Text = "Descrição";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 36);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 7;
            label6.Text = "Código de Barras";
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(26, 58);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(142, 23);
            txtCodBar.TabIndex = 0;
            txtCodBar.Leave += txtCodBar_Leave;
            // 
            // brnAddItem
            // 
            brnAddItem.Location = new Point(547, 36);
            brnAddItem.Name = "brnAddItem";
            brnAddItem.Size = new Size(75, 44);
            brnAddItem.TabIndex = 5;
            brnAddItem.Text = "A&dicionar";
            brnAddItem.UseVisualStyleBackColor = true;
            brnAddItem.Click += brnAddItem_Click;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnValUnit, clnQuantidade, clnDescontoItem, clnTotalItem });
            dgvItensPedido.Location = new Point(12, 101);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.Size = new Size(620, 200);
            dgvItensPedido.TabIndex = 0;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 50;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 90;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 170;
            // 
            // clnValUnit
            // 
            clnValUnit.Frozen = true;
            clnValUnit.HeaderText = "Valor Unit";
            clnValUnit.Name = "clnValUnit";
            clnValUnit.ReadOnly = true;
            clnValUnit.Width = 90;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant.";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 70;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 70;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            clnTotalItem.Width = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 40);
            label1.TabIndex = 2;
            label1.Text = "Novo Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(594, 15);
            label2.Name = "label2";
            label2.Size = new Size(114, 37);
            label2.TabIndex = 3;
            label2.Text = "Número";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdPedido.Location = new Point(725, 19);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(150, 33);
            txtIdPedido.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(725, 554);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(109, 23);
            textBox2.TabIndex = 5;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Location = new Point(725, 505);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(109, 23);
            txtDescontoPedido.TabIndex = 6;
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(725, 461);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.ReadOnly = true;
            txtDescontoItens.Size = new Size(109, 23);
            txtDescontoItens.TabIndex = 7;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(738, 583);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(91, 46);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(725, 415);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(109, 23);
            txtSubTotal.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(747, 397);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 8;
            label12.Text = "Sub Total";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(738, 441);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
            label13.TabIndex = 9;
            label13.Text = "Desconto Itens";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(738, 487);
            label14.Name = "label14";
            label14.Size = new Size(73, 15);
            label14.TabIndex = 10;
            label14.Text = "Desconto R$";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(760, 532);
            label15.Name = "label15";
            label15.Size = new Size(42, 20);
            label15.TabIndex = 11;
            label15.Text = "Total";
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 648);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtSubTotal);
            Controls.Add(txtDescontoItens);
            Controls.Add(txtDescontoPedido);
            Controls.Add(textBox2);
            Controls.Add(txtIdPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grbItens);
            Controls.Add(grbIdentificacao);
            Controls.Add(btnFechar);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            grbIdentificacao.ResumeLayout(false);
            grbIdentificacao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIdentificacao;
        private GroupBox grbItens;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtIdPedido;
        private TextBox txtUsuario;
        private TextBox txtCliente;
        private Label label5;
        private Button btnInserePedido;
        private TextBox txtIdCliente;
        private TextBox txtCodBar;
        private Button brnAddItem;
        private DataGridView dgvItensPedido;
        private Label label10;
        private TextBox txtDescontoItem;
        private Label label9;
        private TextBox txtQuantidade;
        private TextBox txtValorUnit;
        private Label label8;
        private TextBox txtDescricao;
        private Label label7;
        private Label label6;
        private TextBox textBox1;
        private Label label11;
        private TextBox textBox2;
        private TextBox txtDescontoPedido;
        private TextBox txtDescontoItens;
        private Button btnFechar;
        private TextBox txtSubTotal;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
    }
}