namespace StockEletro.Desktop.tela.cliente
{
    partial class ClienteView
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
            lblNome = new Label();
            lblCnpj = new Label();
            lblEstado = new Label();
            lblStatus = new Label();
            btnRecarregar = new Button();
            txtPesquisar = new TextBox();
            dataGridView1 = new DataGridView();
            lblEmpresa1 = new Label();
            cbAtivo = new CheckBox();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            panelMainCliente = new Panel();
            btnEditar = new Button();
            cbEstadoAtuação = new ComboBox();
            btnCadastrar = new Button();
            cbClienteAtivo = new CheckBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            txtLogradouro = new TextBox();
            txtCep = new TextBox();
            txtCnpj = new TextBox();
            txtNomefantasia = new TextBox();
            btnAdicionarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panelMainCliente.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 129);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Location = new Point(101, 129);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(32, 15);
            lblCnpj.TabIndex = 0;
            lblCnpj.Text = "Cnpj";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(177, 129);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Estado";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(265, 129);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status";
            // 
            // btnRecarregar
            // 
            btnRecarregar.Location = new Point(245, 80);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(75, 23);
            btnRecarregar.TabIndex = 1;
            btnRecarregar.Text = "Recarregar";
            btnRecarregar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(12, 80);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(227, 23);
            txtPesquisar.TabIndex = 6;
            txtPesquisar.Text = "Pesquisar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(324, 23);
            dataGridView1.TabIndex = 7;
            // 
            // lblEmpresa1
            // 
            lblEmpresa1.AutoSize = true;
            lblEmpresa1.BackColor = SystemColors.ButtonShadow;
            lblEmpresa1.Location = new Point(12, 147);
            lblEmpresa1.Name = "lblEmpresa1";
            lblEmpresa1.Size = new Size(61, 15);
            lblEmpresa1.TabIndex = 8;
            lblEmpresa1.Text = "Empresa 1";
            // 
            // cbAtivo
            // 
            cbAtivo.AutoSize = true;
            cbAtivo.BackColor = SystemColors.ButtonShadow;
            cbAtivo.Location = new Point(265, 151);
            cbAtivo.Name = "cbAtivo";
            cbAtivo.Size = new Size(54, 19);
            cbAtivo.TabIndex = 10;
            cbAtivo.Text = "Ativo";
            cbAtivo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 11;
            label1.Text = "Cliente";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 27);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(240, 10);
            dataGridView2.TabIndex = 12;
            // 
            // panelMainCliente
            // 
            panelMainCliente.Controls.Add(btnEditar);
            panelMainCliente.Controls.Add(cbEstadoAtuação);
            panelMainCliente.Controls.Add(btnCadastrar);
            panelMainCliente.Controls.Add(cbClienteAtivo);
            panelMainCliente.Controls.Add(txtCidade);
            panelMainCliente.Controls.Add(txtBairro);
            panelMainCliente.Controls.Add(txtComplemento);
            panelMainCliente.Controls.Add(txtNumero);
            panelMainCliente.Controls.Add(txtLogradouro);
            panelMainCliente.Controls.Add(txtCep);
            panelMainCliente.Controls.Add(txtCnpj);
            panelMainCliente.Controls.Add(txtNomefantasia);
            panelMainCliente.Location = new Point(28, 204);
            panelMainCliente.Name = "panelMainCliente";
            panelMainCliente.Size = new Size(400, 169);
            panelMainCliente.TabIndex = 13;
            panelMainCliente.Visible = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.PowderBlue;
            btnEditar.Location = new Point(322, 137);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // cbEstadoAtuação
            // 
            cbEstadoAtuação.FormattingEnabled = true;
            cbEstadoAtuação.Location = new Point(3, 137);
            cbEstadoAtuação.Name = "cbEstadoAtuação";
            cbEstadoAtuação.Size = new Size(222, 23);
            cbEstadoAtuação.TabIndex = 20;
            cbEstadoAtuação.Text = "Estado Atuação";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.YellowGreen;
            btnCadastrar.Location = new Point(237, 136);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 19;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // cbClienteAtivo
            // 
            cbClienteAtivo.AutoSize = true;
            cbClienteAtivo.Location = new Point(249, 95);
            cbClienteAtivo.Name = "cbClienteAtivo";
            cbClienteAtivo.Size = new Size(94, 19);
            cbClienteAtivo.TabIndex = 18;
            cbClienteAtivo.Text = "Cliente Ativo";
            cbClienteAtivo.UseVisualStyleBackColor = true;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(111, 95);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 10;
            txtCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(5, 95);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(100, 23);
            txtBairro.TabIndex = 11;
            txtBairro.Text = "Bairro";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(243, 48);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(100, 23);
            txtComplemento.TabIndex = 12;
            txtComplemento.Text = "Complemento";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(111, 48);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 13;
            txtNumero.Text = "Numero";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(3, 48);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(100, 23);
            txtLogradouro.TabIndex = 14;
            txtLogradouro.Text = "Logradouro";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(243, 7);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 15;
            txtCep.Text = "CEP";
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(109, 7);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(100, 23);
            txtCnpj.TabIndex = 16;
            txtCnpj.Text = "Cnpj";
            // 
            // txtNomefantasia
            // 
            txtNomefantasia.Location = new Point(3, 7);
            txtNomefantasia.Name = "txtNomefantasia";
            txtNomefantasia.Size = new Size(100, 23);
            txtNomefantasia.TabIndex = 17;
            txtNomefantasia.Text = "Nome fantasia";
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.Location = new Point(376, 148);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(126, 23);
            btnAdicionarCliente.TabIndex = 14;
            btnAdicionarCliente.Text = "ADICIONAR NOVO";
            btnAdicionarCliente.UseVisualStyleBackColor = true;
            btnAdicionarCliente.Click += btnAdicionarCliente_Click;
            // 
            // ClienteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(635, 418);
            Controls.Add(btnAdicionarCliente);
            Controls.Add(panelMainCliente);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(cbAtivo);
            Controls.Add(lblEmpresa1);
            Controls.Add(dataGridView1);
            Controls.Add(txtPesquisar);
            Controls.Add(btnRecarregar);
            Controls.Add(lblStatus);
            Controls.Add(lblEstado);
            Controls.Add(lblCnpj);
            Controls.Add(lblNome);
            DoubleBuffered = true;
            Name = "ClienteView";
            Text = "ClienteView";
            Load += ClienteView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panelMainCliente.ResumeLayout(false);
            panelMainCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblCnpj;
        private Label lblEstado;
        private Label lblStatus;
        private Button btnRecarregar;
        private TextBox txtPesquisar;
        private DataGridView dataGridView1;
        private Label lblEmpresa1;
        private CheckBox cbAtivo;
        private Label label1;
        private DataGridView dataGridView2;
        private Panel panelMainCliente;
        private ComboBox cbEstadoAtuação;
        private Button btnCadastrar;
        private CheckBox cbClienteAtivo;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private TextBox txtLogradouro;
        private TextBox txtCep;
        private TextBox txtCnpj;
        private TextBox txtNomefantasia;
        private Button btnAdicionarCliente;
        private Button btnEditar;
    }
}