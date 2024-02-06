namespace StockEletro.Desktop
{
    partial class ColaboradoresView
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
            dgvColaborador = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Cpf = new DataGridViewTextBoxColumn();
            WhatsApp = new DataGridViewTextBoxColumn();
            EndereçoId = new DataGridViewTextBoxColumn();
            DepartamentoId = new DataGridViewTextBoxColumn();
            txtPesquisa = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnCadastraNovoColaborador = new FontAwesome.Sharp.IconButton();
            tabPage2 = new TabPage();
            cmbDepartamentos = new ComboBox();
            btnCadastrar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtLogradouro = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtBairro = new TextBox();
            label6 = new Label();
            txtUf = new TextBox();
            label3 = new Label();
            txtCep = new MaskedTextBox();
            label2 = new Label();
            txtLocalidade = new TextBox();
            txtNome = new TextBox();
            txtCpf = new MaskedTextBox();
            label7 = new Label();
            dtpNascimento = new DateTimePicker();
            txtTelefone = new MaskedTextBox();
            cbxStatus = new CheckBox();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvColaborador).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvColaborador
            // 
            dgvColaborador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvColaborador.Columns.AddRange(new DataGridViewColumn[] { Nome, Status, Cpf, WhatsApp, EndereçoId, DepartamentoId });
            dgvColaborador.Enabled = false;
            dgvColaborador.Location = new Point(22, 89);
            dgvColaborador.Name = "dgvColaborador";
            dgvColaborador.RowHeadersVisible = false;
            dgvColaborador.RowTemplate.Height = 25;
            dgvColaborador.Size = new Size(659, 276);
            dgvColaborador.TabIndex = 0;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // Cpf
            // 
            Cpf.DataPropertyName = "Cpf";
            Cpf.HeaderText = "Cpf";
            Cpf.Name = "Cpf";
            // 
            // WhatsApp
            // 
            WhatsApp.DataPropertyName = "Telefone";
            WhatsApp.HeaderText = "WhatsApp";
            WhatsApp.Name = "WhatsApp";
            // 
            // EndereçoId
            // 
            EndereçoId.DataPropertyName = "EnderecoId";
            EndereçoId.HeaderText = "Endereço";
            EndereçoId.Name = "EndereçoId";
            // 
            // DepartamentoId
            // 
            DepartamentoId.DataPropertyName = "DepartamentoId";
            DepartamentoId.FillWeight = 110F;
            DepartamentoId.HeaderText = "Departamento ";
            DepartamentoId.Name = "DepartamentoId";
            DepartamentoId.Width = 110;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(22, 35);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(158, 29);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.Text = "Pesquisar";
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.AllowDrop = true;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 104);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1068, 533);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(66, 66, 66);
            tabPage1.Controls.Add(btnCadastraNovoColaborador);
            tabPage1.Controls.Add(dgvColaborador);
            tabPage1.Controls.Add(txtPesquisa);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1060, 499);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Colaboradores";
            // 
            // btnCadastraNovoColaborador
            // 
            btnCadastraNovoColaborador.BackColor = Color.FromArgb(1, 104, 181);
            btnCadastraNovoColaborador.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 167, 196);
            btnCadastraNovoColaborador.FlatStyle = FlatStyle.Flat;
            btnCadastraNovoColaborador.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastraNovoColaborador.ForeColor = Color.White;
            btnCadastraNovoColaborador.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnCadastraNovoColaborador.IconColor = Color.White;
            btnCadastraNovoColaborador.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCadastraNovoColaborador.IconSize = 30;
            btnCadastraNovoColaborador.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastraNovoColaborador.Location = new Point(249, 32);
            btnCadastraNovoColaborador.Name = "btnCadastraNovoColaborador";
            btnCadastraNovoColaborador.Size = new Size(219, 32);
            btnCadastraNovoColaborador.TabIndex = 24;
            btnCadastraNovoColaborador.Text = "Cadastra novo colaborador";
            btnCadastraNovoColaborador.UseVisualStyleBackColor = true;
            btnCadastraNovoColaborador.Click += btnCadastraNovoColaborador_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(66, 66, 66);
            tabPage2.Controls.Add(cmbDepartamentos);
            tabPage2.Controls.Add(btnCadastrar);
            tabPage2.Controls.Add(btnBuscar);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(txtEmail);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtLogradouro);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtBairro);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtUf);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtCep);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtLocalidade);
            tabPage2.Controls.Add(txtNome);
            tabPage2.Controls.Add(txtCpf);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(dtpNascimento);
            tabPage2.Controls.Add(txtTelefone);
            tabPage2.Controls.Add(cbxStatus);
            tabPage2.ForeColor = Color.White;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1060, 505);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "AdicionarColaborador";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(502, 117);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(228, 29);
            cmbDepartamentos.TabIndex = 29;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(1, 104, 181);
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 167, 196);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnCadastrar.IconColor = Color.White;
            btnCadastrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCadastrar.IconSize = 30;
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(300, 367);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(118, 32);
            btnCadastrar.TabIndex = 19;
            btnCadastrar.Text = "Cadastra";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(1, 104, 181);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 167, 196);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnBuscar.IconSize = 30;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(175, 180);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(118, 40);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "BUSCAR CEP";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_ClickAsync;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(229, 346);
            label12.Name = "label12";
            label12.Size = new Size(26, 21);
            label12.TabIndex = 28;
            label12.Text = "Uf";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 155);
            label8.Name = "label8";
            label8.Size = new Size(37, 21);
            label8.TabIndex = 24;
            label8.Text = "CEP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 273);
            label9.Name = "label9";
            label9.Size = new Size(86, 21);
            label9.TabIndex = 25;
            label9.Text = "Logadouro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(229, 273);
            label10.Name = "label10";
            label10.Size = new Size(84, 21);
            label10.TabIndex = 26;
            label10.Text = "Localidade";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(36, 329);
            label11.Name = "label11";
            label11.Size = new Size(52, 21);
            label11.TabIndex = 27;
            label11.Text = "Bairro";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(452, 43);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 29);
            txtEmail.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 3);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome Completo";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(36, 297);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(167, 29);
            txtLogradouro.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 82);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 3;
            label4.Text = "Data nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 3);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 4;
            label5.Text = "Status";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(36, 370);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(147, 29);
            txtBairro.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(452, 3);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // txtUf
            // 
            txtUf.Location = new Point(229, 370);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(57, 29);
            txtUf.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 82);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 2;
            label3.Text = "Celular";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(36, 191);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(132, 29);
            txtCep.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 82);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 1;
            label2.Text = "CPF";
            // 
            // txtLocalidade
            // 
            txtLocalidade.Location = new Point(229, 297);
            txtLocalidade.Name = "txtLocalidade";
            txtLocalidade.Size = new Size(218, 29);
            txtLocalidade.TabIndex = 22;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(36, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(295, 29);
            txtNome.TabIndex = 6;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(175, 114);
            txtCpf.Mask = "000.000.000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(111, 29);
            txtCpf.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(498, 82);
            label7.Name = "label7";
            label7.Size = new Size(110, 21);
            label7.TabIndex = 18;
            label7.Text = "Departamento";
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(321, 114);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(145, 29);
            dtpNascimento.TabIndex = 14;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(36, 114);
            txtTelefone.Mask = "(00)00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(111, 29);
            txtTelefone.TabIndex = 17;
            // 
            // cbxStatus
            // 
            cbxStatus.AutoSize = true;
            cbxStatus.Location = new Point(353, 43);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(65, 25);
            cbxStatus.TabIndex = 16;
            cbxStatus.Text = "Ativo";
            cbxStatus.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(249, 137, 71);
            label13.Location = new Point(12, 9);
            label13.Name = "label13";
            label13.Size = new Size(380, 54);
            label13.TabIndex = 22;
            label13.Text = "COLABORADORES";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(249, 137, 71);
            pictureBox1.Location = new Point(21, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 10);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // ColaboradoresView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 66, 66);
            ClientSize = new Size(1092, 649);
            Controls.Add(pictureBox1);
            Controls.Add(label13);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ColaboradoresView";
            Text = "Colaborador";
            Load += ColaboradoresView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvColaborador).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvColaborador;
        private TextBox txtPesquisa;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtLogradouro;
        private TextBox txtBairro;
        private TextBox txtUf;
        private MaskedTextBox txtCep;
        private TextBox txtLocalidade;
        private TextBox txtEmail;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private TextBox txtNome;
        private MaskedTextBox txtCpf;
        private Label label7;
        private DateTimePicker dtpNascimento;
        private MaskedTextBox txtTelefone;
        private CheckBox cbxStatus;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnCadastrar;
        private Label label12;
        private ComboBox cmbDepartamentos;
        private Label label13;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnCadastraNovoColaborador;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn WhatsApp;
        private DataGridViewTextBoxColumn EndereçoId;
        private DataGridViewTextBoxColumn DepartamentoId;
    }
}