namespace StockEletro.Desktop.Tela.Colaboradores
{
    partial class AdicionaColaboradorView
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
            tableLayoutPanel3 = new TableLayoutPanel();
            btnBuscarPorCep = new Button();
            txtCep = new MaskedTextBox();
            txtLogradouro = new TextBox();
            txtBairro = new TextBox();
            txtUf = new TextBox();
            txtLocalidade = new TextBox();
            tblColaborador = new TableLayoutPanel();
            txtEmail = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            tblPnlButton = new TableLayoutPanel();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtCpf = new MaskedTextBox();
            dtpNascimento = new DateTimePicker();
            cbxStatus = new CheckBox();
            txtTelefone = new MaskedTextBox();
            tableLayoutPanel3.SuspendLayout();
            tblColaborador.SuspendLayout();
            tblPnlButton.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(btnBuscarPorCep, 1, 0);
            tableLayoutPanel3.Controls.Add(txtCep, 0, 0);
            tableLayoutPanel3.Controls.Add(txtLogradouro, 0, 1);
            tableLayoutPanel3.Controls.Add(txtBairro, 0, 2);
            tableLayoutPanel3.Controls.Add(txtUf, 0, 5);
            tableLayoutPanel3.Controls.Add(txtLocalidade, 1, 1);
            tableLayoutPanel3.Location = new Point(13, 202);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(715, 150);
            tableLayoutPanel3.TabIndex = 18;
            // 
            // btnBuscarPorCep
            // 
            btnBuscarPorCep.Location = new Point(176, 3);
            btnBuscarPorCep.Name = "btnBuscarPorCep";
            btnBuscarPorCep.Size = new Size(75, 23);
            btnBuscarPorCep.TabIndex = 15;
            btnBuscarPorCep.Text = "BUSCAR";
            btnBuscarPorCep.UseVisualStyleBackColor = true;
            btnBuscarPorCep.Click += btnBuscarPorCep_Click;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(3, 3);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(132, 23);
            txtCep.TabIndex = 16;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(3, 32);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(167, 23);
            txtLogradouro.TabIndex = 17;
            txtLogradouro.Text = "Logradouro";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(3, 61);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(147, 23);
            txtBairro.TabIndex = 20;
            txtBairro.Text = "bairro";
            // 
            // txtUf
            // 
            txtUf.Location = new Point(3, 90);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(57, 23);
            txtUf.TabIndex = 23;
            txtUf.Text = "Uf";
            // 
            // txtLocalidade
            // 
            txtLocalidade.Location = new Point(176, 32);
            txtLocalidade.Name = "txtLocalidade";
            txtLocalidade.Size = new Size(218, 23);
            txtLocalidade.TabIndex = 22;
            txtLocalidade.Text = "Localidade";
            // 
            // tblColaborador
            // 
            tblColaborador.ColumnCount = 4;
            tblColaborador.ColumnStyles.Add(new ColumnStyle());
            tblColaborador.ColumnStyles.Add(new ColumnStyle());
            tblColaborador.ColumnStyles.Add(new ColumnStyle());
            tblColaborador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblColaborador.Controls.Add(txtEmail, 3, 2);
            tblColaborador.Controls.Add(label1, 0, 0);
            tblColaborador.Controls.Add(label4, 2, 0);
            tblColaborador.Controls.Add(label5, 2, 1);
            tblColaborador.Controls.Add(label6, 2, 2);
            tblColaborador.Controls.Add(label3, 0, 1);
            tblColaborador.Controls.Add(label2, 0, 2);
            tblColaborador.Controls.Add(txtNome, 1, 0);
            tblColaborador.Controls.Add(tblPnlButton, 3, 3);
            tblColaborador.Controls.Add(txtCpf, 1, 2);
            tblColaborador.Controls.Add(dtpNascimento, 3, 0);
            tblColaborador.Controls.Add(cbxStatus, 3, 1);
            tblColaborador.Controls.Add(txtTelefone, 1, 1);
            tblColaborador.Location = new Point(13, 60);
            tblColaborador.Name = "tblColaborador";
            tblColaborador.RowCount = 4;
            tblColaborador.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblColaborador.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblColaborador.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tblColaborador.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblColaborador.Size = new Size(715, 136);
            tblColaborador.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(508, 55);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 23);
            txtEmail.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome Completo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 3;
            label4.Text = "Data nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 26);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(406, 52);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 26);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Celular";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 52);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "CPF";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(105, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(295, 23);
            txtNome.TabIndex = 6;
            // 
            // tblPnlButton
            // 
            tblPnlButton.ColumnCount = 2;
            tblPnlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPnlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPnlButton.Controls.Add(btnCancelar, 1, 0);
            tblPnlButton.Controls.Add(btnSalvar, 0, 0);
            tblPnlButton.Location = new Point(508, 87);
            tblPnlButton.Name = "tblPnlButton";
            tblPnlButton.RowCount = 1;
            tblPnlButton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPnlButton.Size = new Size(170, 46);
            tblPnlButton.TabIndex = 12;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.Location = new Point(88, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(3, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(67, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(105, 55);
            txtCpf.Mask = "000.000.000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(111, 23);
            txtCpf.TabIndex = 13;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(508, 3);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(170, 23);
            dtpNascimento.TabIndex = 14;
            // 
            // cbxStatus
            // 
            cbxStatus.AutoSize = true;
            cbxStatus.Location = new Point(508, 29);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(54, 19);
            cbxStatus.TabIndex = 16;
            cbxStatus.Text = "Ativo";
            cbxStatus.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(105, 29);
            txtTelefone.Mask = "( )00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(111, 23);
            txtTelefone.TabIndex = 17;
            // 
            // AdicionaColaboradorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 420);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tblColaborador);
            Name = "AdicionaColaboradorView";
            Text = "AdicionaColaboradorView";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tblColaborador.ResumeLayout(false);
            tblColaborador.PerformLayout();
            tblPnlButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Button btnBuscarPorCep;
        private MaskedTextBox txtCep;
        private TextBox txtLogradouro;
        private TextBox txtBairro;
        private TableLayoutPanel tblColaborador;
        private TextBox txtEmail;
        private Label label1;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private TextBox txtNome;
        private TableLayoutPanel tblPnlButton;
        private Button btnCancelar;
        private Button btnSalvar;
        private MaskedTextBox txtCpf;
        private DateTimePicker dtpNascimento;
        private DateTimePicker dateTimePicker1;
        private CheckBox cbxStatus;
        private TextBox txtLocalidade;
        private TextBox txtUf;
        private MaskedTextBox txtTelefone;
    }
}