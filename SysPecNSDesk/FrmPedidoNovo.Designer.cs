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
            groupBox1 = new GroupBox();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            label5 = new Label();
            txtCliente = new TextBox();
            txtUsuario = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtIdPedido = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnInserePedido);
            groupBox1.Controls.Add(txtIdCliente);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(47, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Identificação";
            // 
            // btnInserePedido
            // 
            btnInserePedido.Location = new Point(373, 87);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(75, 23);
            btnInserePedido.TabIndex = 6;
            btnInserePedido.Text = "&Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(79, 87);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(65, 23);
            txtIdCliente.TabIndex = 5;
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
            txtCliente.TabIndex = 3;
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
            // groupBox2
            // 
            groupBox2.Location = new Point(47, 254);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(540, 228);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Itens de Pedido";
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
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 574);
            Controls.Add(txtIdPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
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
    }
}