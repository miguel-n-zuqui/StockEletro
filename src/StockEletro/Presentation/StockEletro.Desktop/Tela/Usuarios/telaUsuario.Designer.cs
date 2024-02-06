namespace StockPhone.Desktop.Telas
{
    partial class TelaUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            btnSalvar = new FontAwesome.Sharp.IconButton();
            chkAtivo = new CheckBox();
            cmbColaborador = new ComboBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            groupBoxCadastrar = new GroupBox();
            btnNovo = new FontAwesome.Sharp.IconButton();
            gvUsuario = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            DataCadastro = new DataGridViewTextBoxColumn();
            DataAlteracao = new DataGridViewTextBoxColumn();
            Deletar = new DataGridViewImageColumn();
            Editar = new DataGridViewImageColumn();
            Senha = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Colaborador = new DataGridViewTextBoxColumn();
            groupBoxCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(1, 104, 181);
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 167, 196);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnSalvar.IconColor = Color.White;
            btnSalvar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnSalvar.IconSize = 30;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(848, 157);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(116, 41);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            btnSalvar.MouseEnter += btnSalvar_MouseEnter;
            btnSalvar.MouseLeave += btnSalvar_MouseLeave;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chkAtivo.Location = new Point(765, 115);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(70, 25);
            chkAtivo.TabIndex = 1;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // cmbColaborador
            // 
            cmbColaborador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbColaborador.ForeColor = SystemColors.Desktop;
            cmbColaborador.FormattingEnabled = true;
            cmbColaborador.Location = new Point(23, 27);
            cmbColaborador.Name = "cmbColaborador";
            cmbColaborador.Size = new Size(263, 29);
            cmbColaborador.TabIndex = 2;
            cmbColaborador.SelectedIndexChanged += cmbColaborador_SelectedIndexChanged;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.InactiveCaption;
            txtNome.Location = new Point(316, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(308, 29);
            txtNome.TabIndex = 3;
            txtNome.Text = "Nome Completo";
            txtNome.Click += txtNome_Click;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = SystemColors.InactiveCaption;
            txtEmail.Location = new Point(651, 27);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(299, 29);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "Email:";
            txtEmail.Click += txtEmail_Click;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.InactiveCaption;
            txtUsuario.Location = new Point(56, 108);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(299, 29);
            txtUsuario.TabIndex = 5;
            txtUsuario.Text = "Usuario:";
            txtUsuario.Click += txtUsuario_Click;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.ForeColor = SystemColors.InactiveCaption;
            txtSenha.Location = new Point(421, 108);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(290, 29);
            txtSenha.TabIndex = 6;
            txtSenha.Text = "Senha:";
            txtSenha.Click += txtSenha_Click;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // groupBoxCadastrar
            // 
            groupBoxCadastrar.Controls.Add(txtSenha);
            groupBoxCadastrar.Controls.Add(btnSalvar);
            groupBoxCadastrar.Controls.Add(txtUsuario);
            groupBoxCadastrar.Controls.Add(chkAtivo);
            groupBoxCadastrar.Controls.Add(txtEmail);
            groupBoxCadastrar.Controls.Add(cmbColaborador);
            groupBoxCadastrar.Controls.Add(txtNome);
            groupBoxCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxCadastrar.Location = new Point(3, 173);
            groupBoxCadastrar.Name = "groupBoxCadastrar";
            groupBoxCadastrar.Size = new Size(976, 208);
            groupBoxCadastrar.TabIndex = 7;
            groupBoxCadastrar.TabStop = false;
            groupBoxCadastrar.Text = "Cadastrar";
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.FromArgb(1, 104, 181);
            btnNovo.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 167, 196);
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNovo.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnNovo.IconColor = Color.White;
            btnNovo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNovo.IconSize = 30;
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.Location = new Point(12, 95);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(118, 32);
            btnNovo.TabIndex = 7;
            btnNovo.Text = "  Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            btnNovo.MouseEnter += btnNovo_MouseEnter;
            btnNovo.MouseLeave += btnNovo_MouseLeave;
            // 
            // gvUsuario
            // 
            gvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvUsuario.Columns.AddRange(new DataGridViewColumn[] { id, Nome, Email, Status, DataCadastro, DataAlteracao, Deletar, Editar, Senha, Usuario, Colaborador });
            gvUsuario.Dock = DockStyle.Bottom;
            gvUsuario.Location = new Point(0, 385);
            gvUsuario.Name = "gvUsuario";
            gvUsuario.RowTemplate.Height = 25;
            gvUsuario.Size = new Size(1092, 264);
            gvUsuario.TabIndex = 8;
            gvUsuario.CellClick += gvUsuario_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(249, 137, 71);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 54);
            label1.TabIndex = 10;
            label1.Text = "USUÁRIO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(249, 137, 71);
            pictureBox1.Location = new Point(16, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 10);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            dataGridViewCellStyle1.ForeColor = Color.Black;
            id.DefaultCellStyle = dataGridViewCellStyle1;
            id.HeaderText = "Id";
            id.Name = "id";
            id.Width = 60;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            dataGridViewCellStyle2.ForeColor = Color.Black;
            Nome.DefaultCellStyle = dataGridViewCellStyle2;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.Width = 200;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            dataGridViewCellStyle3.ForeColor = Color.Black;
            Email.DefaultCellStyle = dataGridViewCellStyle3;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.Width = 200;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.NullValue = false;
            Status.DefaultCellStyle = dataGridViewCellStyle4;
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // DataCadastro
            // 
            DataCadastro.DataPropertyName = "CriadoEm";
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            DataCadastro.DefaultCellStyle = dataGridViewCellStyle5;
            DataCadastro.HeaderText = "Data de Cadastro";
            DataCadastro.Name = "DataCadastro";
            DataCadastro.Resizable = DataGridViewTriState.True;
            DataCadastro.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DataAlteracao
            // 
            DataAlteracao.DataPropertyName = "AlteradoEm";
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            DataAlteracao.DefaultCellStyle = dataGridViewCellStyle6;
            DataAlteracao.HeaderText = "Data de Alteração";
            DataAlteracao.Name = "DataAlteracao";
            DataAlteracao.Resizable = DataGridViewTriState.True;
            DataAlteracao.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Deletar
            // 
            Deletar.HeaderText = "Deletar";
            Deletar.Name = "Deletar";
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = StockEletro.Desktop.Properties.Resources.icons8_editar_20;
            Editar.Name = "Editar";
            // 
            // Senha
            // 
            Senha.DataPropertyName = "Senha";
            dataGridViewCellStyle7.ForeColor = Color.Black;
            Senha.DefaultCellStyle = dataGridViewCellStyle7;
            Senha.HeaderText = "Senha";
            Senha.Name = "Senha";
            Senha.Visible = false;
            // 
            // Usuario
            // 
            Usuario.DataPropertyName = "User";
            dataGridViewCellStyle8.ForeColor = Color.Black;
            Usuario.DefaultCellStyle = dataGridViewCellStyle8;
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.Visible = false;
            // 
            // Colaborador
            // 
            Colaborador.DataPropertyName = "IdColaborador";
            dataGridViewCellStyle9.ForeColor = Color.Black;
            Colaborador.DefaultCellStyle = dataGridViewCellStyle9;
            Colaborador.HeaderText = "Colaborador";
            Colaborador.Name = "Colaborador";
            Colaborador.Visible = false;
            // 
            // telaUsuario
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 66, 66);
            ClientSize = new Size(1092, 649);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(gvUsuario);
            Controls.Add(btnNovo);
            Controls.Add(groupBoxCadastrar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "telaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "telaUsuario";
            Load += telaUsuario_Load;
            groupBoxCadastrar.ResumeLayout(false);
            groupBoxCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSalvar;
        private CheckBox chkAtivo;
        private ComboBox cmbColaborador;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private GroupBox groupBoxCadastrar;
        private FontAwesome.Sharp.IconButton btnNovo;
        private DataGridView gvUsuario;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewTextBoxColumn DataCadastro;
        private DataGridViewTextBoxColumn DataAlteracao;
        private DataGridViewImageColumn Deletar;
        private DataGridViewImageColumn Editar;
        private DataGridViewTextBoxColumn Senha;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Colaborador;
    }
}