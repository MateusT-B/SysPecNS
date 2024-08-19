namespace SysPecNSDesk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfirma = new Button();
            txtNumero1 = new TextBox();
            lstResultado = new ListBox();
            cmbOperacao = new ComboBox();
            Operação = new Label();
            txtNumero2 = new TextBox();
            Valor2 = new Label();
            Valor1 = new Label();
            SuspendLayout();
            // 
            // btnConfirma
            // 
            btnConfirma.Enabled = false;
            btnConfirma.Location = new Point(433, 375);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(75, 23);
            btnConfirma.TabIndex = 0;
            btnConfirma.Text = "&Confirma";
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(275, 101);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(114, 23);
            txtNumero1.TabIndex = 1;
            txtNumero1.TextChanged += textBox1_TextChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(275, 155);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(233, 214);
            lstResultado.TabIndex = 2;
            lstResultado.SelectedIndexChanged += lstResultado_SelectedIndexChanged;
            // 
            // cmbOperacao
            // 
            cmbOperacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacao.FormattingEnabled = true;
            cmbOperacao.Items.AddRange(new object[] { "Multiplacação", "Divisão", "Adição", "Subtração", "Exponenciação", "Radiciação", "Logarítimos" });
            cmbOperacao.Location = new Point(148, 101);
            cmbOperacao.Name = "cmbOperacao";
            cmbOperacao.Size = new Size(121, 23);
            cmbOperacao.TabIndex = 3;
            cmbOperacao.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Operação
            // 
            Operação.AutoSize = true;
            Operação.Location = new Point(181, 67);
            Operação.Name = "Operação";
            Operação.Size = new Size(58, 15);
            Operação.TabIndex = 4;
            Operação.Text = "Operação";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(408, 101);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 5;
            txtNumero2.TextChanged += txtNumero2_TextChanged;
            // 
            // Valor2
            // 
            Valor2.AutoSize = true;
            Valor2.Location = new Point(442, 67);
            Valor2.Name = "Valor2";
            Valor2.Size = new Size(42, 15);
            Valor2.TabIndex = 6;
            Valor2.Text = "Valor 2";
            // 
            // Valor1
            // 
            Valor1.AutoSize = true;
            Valor1.Location = new Point(314, 67);
            Valor1.Name = "Valor1";
            Valor1.Size = new Size(42, 15);
            Valor1.TabIndex = 7;
            Valor1.Text = "Valor 1";
            Valor1.Click += Valor1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Valor1);
            Controls.Add(Valor2);
            Controls.Add(txtNumero2);
            Controls.Add(Operação);
            Controls.Add(cmbOperacao);
            Controls.Add(lstResultado);
            Controls.Add(txtNumero1);
            Controls.Add(btnConfirma);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirma;
        private TextBox txtNumero1;
        private ListBox lstResultado;
        private ComboBox cmbOperacao;
        private Label Operação;
        private TextBox txtNumero2;
        private Label Valor2;
        private Label Valor1;
    }
}
