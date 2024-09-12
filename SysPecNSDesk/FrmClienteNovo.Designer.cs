namespace SysPecNSDesk
{
    partial class FrmClienteNovo
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
            gpbClienteEndereco = new GroupBox();
            tpClienteEnd = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            clnIdCliente = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            lblDataCadastro = new Label();
            dtpDataCadastro = new DateTimePicker();
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
            cmbUf = new ComboBox();
            cmbTipoEndereco = new ComboBox();
            label9 = new Label();
            btnEditarEndereco = new Button();
            btnInserirEndereço = new Button();
            label8 = new Label();
            txtNumero = new TextBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtComplemento = new TextBox();
            label7 = new Label();
            txtCep = new TextBox();
            txtLogradouro = new TextBox();
            txtIdEndereco = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnCep = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnUf = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            gpbClienteEndereco.SuspendLayout();
            tpClienteEnd.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // gpbClienteEndereco
            // 
            gpbClienteEndereco.Controls.Add(tpClienteEnd);
            gpbClienteEndereco.Location = new Point(187, 59);
            gpbClienteEndereco.Name = "gpbClienteEndereco";
            gpbClienteEndereco.Size = new Size(628, 563);
            gpbClienteEndereco.TabIndex = 1;
            gpbClienteEndereco.TabStop = false;
            // 
            // tpClienteEnd
            // 
            tpClienteEnd.Controls.Add(tabPage1);
            tpClienteEnd.Controls.Add(tabPage2);
            tpClienteEnd.Location = new Point(21, 22);
            tpClienteEnd.Name = "tpClienteEnd";
            tpClienteEnd.SelectedIndex = 0;
            tpClienteEnd.Size = new Size(593, 521);
            tpClienteEnd.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(lblDataCadastro);
            tabPage1.Controls.Add(dtpDataCadastro);
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
            tabPage1.ImeMode = ImeMode.On;
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnIdCliente, clnNome, clnEmail, clnCpf, clnTelefone, clnAtivo });
            dataGridView1.Location = new Point(26, 326);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(533, 150);
            dataGridView1.TabIndex = 19;
            // 
            // clnIdCliente
            // 
            clnIdCliente.Frozen = true;
            clnIdCliente.HeaderText = "ID";
            clnIdCliente.Name = "clnIdCliente";
            clnIdCliente.ReadOnly = true;
            clnIdCliente.Width = 70;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            // 
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            // 
            // clnTelefone
            // 
            clnTelefone.Frozen = true;
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Location = new Point(367, 213);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(97, 15);
            lblDataCadastro.TabIndex = 18;
            lblDataCadastro.Text = "Data de Cadastro";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Format = DateTimePickerFormat.Short;
            dtpDataCadastro.Location = new Point(364, 228);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(126, 23);
            dtpDataCadastro.TabIndex = 17;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(364, 277);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(137, 277);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 13;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // lblDataDeNascimento
            // 
            lblDataDeNascimento.AutoSize = true;
            lblDataDeNascimento.Location = new Point(367, 154);
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
            chkAtivo.Location = new Point(29, 201);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 10;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(26, 172);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(183, 23);
            txtTelefone.TabIndex = 9;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(26, 154);
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
            lblEmail.Location = new Point(29, 97);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(140, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(29, 24);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 4;
            lblID.Text = "ID";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(318, 112);
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
            txtIdCliente.ForeColor = SystemColors.WindowText;
            txtIdCliente.Location = new Point(26, 39);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.ReadOnly = true;
            txtIdCliente.Size = new Size(65, 23);
            txtIdCliente.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cmbUf);
            tabPage2.Controls.Add(cmbTipoEndereco);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(btnEditarEndereco);
            tabPage2.Controls.Add(btnInserirEndereço);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtNumero);
            tabPage2.Controls.Add(txtCidade);
            tabPage2.Controls.Add(txtBairro);
            tabPage2.Controls.Add(txtComplemento);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtCep);
            tabPage2.Controls.Add(txtLogradouro);
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
            tabPage2.Text = "Endereço";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbUf
            // 
            cmbUf.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUf.FormattingEnabled = true;
            cmbUf.Items.AddRange(new object[] { "RO", "AC", "AM", "RR", "PA", "AP", "TO", "MA", "PI", "CE", "RN", "PB", "PE", "AL", "SE", "BA", "MG", "ES", "RJ", "SP", "PR", "SC", "RS", "MS", "MT", "GO", "DF" });
            cmbUf.Location = new Point(311, 110);
            cmbUf.Name = "cmbUf";
            cmbUf.Size = new Size(66, 23);
            cmbUf.TabIndex = 23;
            // 
            // cmbTipoEndereco
            // 
            cmbTipoEndereco.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoEndereco.FormattingEnabled = true;
            cmbTipoEndereco.Items.AddRange(new object[] { "RES - Residencial", "COM - Comercial", "ENT - Entrega", "COB - Cobrança", "RET - Retirada", "TMP - Temporário" });
            cmbTipoEndereco.Location = new Point(425, 203);
            cmbTipoEndereco.Name = "cmbTipoEndereco";
            cmbTipoEndereco.Size = new Size(121, 23);
            cmbTipoEndereco.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(437, 188);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 21;
            label9.Text = "Tipo Endereço";
            // 
            // btnEditarEndereco
            // 
            btnEditarEndereco.Location = new Point(344, 282);
            btnEditarEndereco.Name = "btnEditarEndereco";
            btnEditarEndereco.Size = new Size(75, 23);
            btnEditarEndereco.TabIndex = 18;
            btnEditarEndereco.Text = "&Editar";
            btnEditarEndereco.UseVisualStyleBackColor = true;
            // 
            // btnInserirEndereço
            // 
            btnInserirEndereço.Location = new Point(151, 282);
            btnInserirEndereço.Name = "btnInserirEndereço";
            btnInserirEndereço.Size = new Size(75, 23);
            btnInserirEndereço.TabIndex = 17;
            btnInserirEndereço.Text = "&Inserir";
            btnInserirEndereço.UseVisualStyleBackColor = true;
            btnInserirEndereço.Click += btnInserirEndereço_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(195, 92);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 16;
            label8.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(174, 110);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 15;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(417, 110);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(148, 23);
            txtCidade.TabIndex = 14;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(174, 203);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(203, 23);
            txtBairro.TabIndex = 13;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(32, 203);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(100, 23);
            txtComplemento.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 92);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 11;
            label7.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(31, 107);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 9;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(174, 39);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(372, 23);
            txtLogradouro.TabIndex = 8;
            // 
            // txtIdEndereco
            // 
            txtIdEndereco.Location = new Point(31, 39);
            txtIdEndereco.Name = "txtIdEndereco";
            txtIdEndereco.Size = new Size(67, 23);
            txtIdEndereco.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(462, 92);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 6;
            label6.Text = "Cidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 92);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 5;
            label5.Text = "UF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 188);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "Bairro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 188);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 3;
            label3.Text = "Complemento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 24);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Logradouro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 24);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { clnId, clnLogradouro, clnCep, clnNumero, clnUf, clnComplemento, clnBairro });
            dataGridView2.Location = new Point(31, 342);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(534, 133);
            dataGridView2.TabIndex = 0;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnLogradouro
            // 
            clnLogradouro.Frozen = true;
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            // 
            // clnCep
            // 
            clnCep.Frozen = true;
            clnCep.HeaderText = "Cep";
            clnCep.Name = "clnCep";
            clnCep.ReadOnly = true;
            clnCep.Width = 70;
            // 
            // clnNumero
            // 
            clnNumero.Frozen = true;
            clnNumero.HeaderText = "Número";
            clnNumero.Name = "clnNumero";
            clnNumero.ReadOnly = true;
            clnNumero.Width = 80;
            // 
            // clnUf
            // 
            clnUf.Frozen = true;
            clnUf.HeaderText = "UF";
            clnUf.Name = "clnUf";
            clnUf.ReadOnly = true;
            clnUf.Width = 50;
            // 
            // clnComplemento
            // 
            clnComplemento.Frozen = true;
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.Frozen = true;
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            clnBairro.Width = 80;
            // 
            // FrmClienteNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 682);
            Controls.Add(gpbClienteEndereco);
            Name = "FrmClienteNovo";
            Text = "FrmClienteNovo";
            gpbClienteEndereco.ResumeLayout(false);
            tpClienteEnd.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbClienteEndereco;
        private TabControl tpClienteEnd;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clnIdCliente;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnAtivo;
        private Label lblDataCadastro;
        private DateTimePicker dtpDataCadastro;
        private Button btnEditar;
        private Button btnInserir;
        private Label lblDataDeNascimento;
        private DateTimePicker dtpDataDeNascimento;
        private CheckBox chkAtivo;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private Label lblCpf;
        private Label lblEmail;
        private Label lblNome;
        private Label lblID;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtIdCliente;
        private TabPage tabPage2;
        private ComboBox cmbTipoEndereco;
        private Label label9;
        private Button btnEditarEndereco;
        private Button btnInserirEndereço;
        private Label label8;
        private TextBox txtNumero;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private Label label7;
        private TextBox txtCep;
        private TextBox txtLogradouro;
        private TextBox txtIdEndereco;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnUf;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private ComboBox cmbUf;
    }
}