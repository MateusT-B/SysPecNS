namespace SysPecNSDesk
{
    partial class FrmCliente
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
            tabPage = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            lblDataCadastro = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnCancelar = new Button();
            btnDeletar = new Button();
            btnEditar = new Button();
            btnInserir = new Button();
            lblDataDeNascimento = new Label();
            dtpDataDeNascimento = new DateTimePicker();
            chkAtivo = new CheckBox();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            lblCpf = new Label();
            lblEmail = new Label();
            lblNome = new Label();
            lblID = new Label();
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtIdCliente = new TextBox();
            tabPage2 = new TabPage();
            textBox3 = new TextBox();
            label7 = new Label();
            cmbUf = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtIdEndereco = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            tabPage.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabPage);
            groupBox1.Location = new Point(98, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(605, 560);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tabPage
            // 
            tabPage.Controls.Add(tabPage1);
            tabPage.Controls.Add(tabPage2);
            tabPage.Location = new Point(6, 22);
            tabPage.Name = "tabPage";
            tabPage.SelectedIndex = 0;
            tabPage.Size = new Size(593, 521);
            tabPage.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(lblDataCadastro);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(btnDeletar);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(btnInserir);
            tabPage1.Controls.Add(lblDataDeNascimento);
            tabPage1.Controls.Add(dtpDataDeNascimento);
            tabPage1.Controls.Add(chkAtivo);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Controls.Add(lblTelefone);
            tabPage1.Controls.Add(lblCpf);
            tabPage1.Controls.Add(lblEmail);
            tabPage1.Controls.Add(lblNome);
            tabPage1.Controls.Add(lblID);
            tabPage1.Controls.Add(txtCpf);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(txtIdCliente);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(585, 493);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 326);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(526, 150);
            dataGridView1.TabIndex = 19;
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Location = new Point(381, 203);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(97, 15);
            lblDataCadastro.TabIndex = 18;
            lblDataCadastro.Text = "Data de Cadastro";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(364, 228);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(126, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(425, 277);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(294, 277);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 15;
            btnDeletar.Text = "&Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(160, 277);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(29, 277);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 13;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // lblDataDeNascimento
            // 
            lblDataDeNascimento.AutoSize = true;
            lblDataDeNascimento.Location = new Point(376, 151);
            lblDataDeNascimento.Name = "lblDataDeNascimento";
            lblDataDeNascimento.Size = new Size(114, 15);
            lblDataDeNascimento.TabIndex = 12;
            lblDataDeNascimento.Text = "Data de Nascimento";
            // 
            // dtpDataDeNascimento
            // 
            dtpDataDeNascimento.Format = DateTimePickerFormat.Short;
            dtpDataDeNascimento.Location = new Point(364, 169);
            dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            dtpDataDeNascimento.Size = new Size(126, 23);
            dtpDataDeNascimento.TabIndex = 11;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(29, 203);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 10;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(29, 172);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(183, 23);
            txtTelefone.TabIndex = 9;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(29, 151);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 8;
            lblTelefone.Text = "Telefone";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(318, 94);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 7;
            lblCpf.Text = "CPF";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(29, 94);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(147, 21);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(29, 21);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 4;
            lblID.Text = "ID";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(307, 112);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(209, 23);
            txtCpf.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(26, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(235, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(137, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(379, 23);
            txtNome.TabIndex = 1;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(26, 39);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(65, 23);
            txtIdCliente.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(cmbUf);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(txtIdEndereco);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(585, 493);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Endereco";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(32, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 89);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 11;
            label7.Text = "CEP";
            // 
            // cmbUf
            // 
            cmbUf.FormattingEnabled = true;
            cmbUf.Location = new Point(398, 110);
            cmbUf.Name = "cmbUf";
            cmbUf.Size = new Size(86, 23);
            cmbUf.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(372, 23);
            textBox2.TabIndex = 8;
            // 
            // txtIdEndereco
            // 
            txtIdEndereco.Location = new Point(31, 39);
            txtIdEndereco.Name = "txtIdEndereco";
            txtIdEndereco.Size = new Size(100, 23);
            txtIdEndereco.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(398, 185);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 6;
            label6.Text = "Cidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 89);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 5;
            label5.Text = "UF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 185);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "Bairro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 185);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 3;
            label3.Text = "Complemento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 21);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Logradouro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 21);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(21, 342);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(543, 133);
            dataGridView2.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(174, 203);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(203, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(398, 203);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(148, 23);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(241, 110);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(241, 89);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 16;
            label8.Text = "Número";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 617);
            Controls.Add(groupBox1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            groupBox1.ResumeLayout(false);
            tabPage.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl tabPage;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblID;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtIdCliente;
        private Label lblEmail;
        private Label lblNome;
        private Label lblCpf;
        private Label lblDataDeNascimento;
        private DateTimePicker dtpDataDeNascimento;
        private CheckBox chkAtivo;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private Button btnCancelar;
        private Button btnDeletar;
        private Button btnEditar;
        private Button btnInserir;
        private DateTimePicker dateTimePicker1;
        private Label lblDataCadastro;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private TextBox txtIdEndereco;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView2;
        private Label label7;
        private ComboBox cmbUf;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
    }
}