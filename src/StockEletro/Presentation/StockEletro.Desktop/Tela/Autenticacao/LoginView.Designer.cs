namespace StockEletro.Desktop.Tela.Autenticacao
{
    partial class LoginView
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
            components = new System.ComponentModel.Container();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblMensagemDeErro = new Label();
            btnFazerLogin = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnSair = new FontAwesome.Sharp.IconButton();
            pictureboxLogin = new FontAwesome.Sharp.IconPictureBox();
            pictureBoxSenha = new FontAwesome.Sharp.IconPictureBox();
            llblRecuperarSenha = new LinkLabel();
            pictureBox2 = new PictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(857, 264);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(857, 396);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(250, 23);
            txtSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(944, 211);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(950, 338);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // lblMensagemDeErro
            // 
            lblMensagemDeErro.AutoSize = true;
            lblMensagemDeErro.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensagemDeErro.ForeColor = Color.Red;
            lblMensagemDeErro.Location = new Point(857, 186);
            lblMensagemDeErro.Name = "lblMensagemDeErro";
            lblMensagemDeErro.Size = new Size(250, 25);
            lblMensagemDeErro.TabIndex = 6;
            lblMensagemDeErro.Text = "Usuario ou senha incorretos";
            lblMensagemDeErro.Visible = false;
            // 
            // btnFazerLogin
            // 
            btnFazerLogin.BackColor = Color.FromArgb(1, 104, 181);
            btnFazerLogin.FlatAppearance.BorderSize = 0;
            btnFazerLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 17, 255);
            btnFazerLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 17, 157);
            btnFazerLogin.FlatStyle = FlatStyle.Flat;
            btnFazerLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFazerLogin.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnFazerLogin.IconColor = Color.Black;
            btnFazerLogin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnFazerLogin.IconSize = 35;
            btnFazerLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnFazerLogin.Location = new Point(864, 538);
            btnFazerLogin.Margin = new Padding(0);
            btnFazerLogin.Name = "btnFazerLogin";
            btnFazerLogin.Size = new Size(250, 43);
            btnFazerLogin.TabIndex = 7;
            btnFazerLogin.Text = "ENTRAR";
            btnFazerLogin.UseVisualStyleBackColor = false;
            btnFazerLogin.Click += btnFazerLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(-4, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(713, 767);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 54, 54);
            panel1.Controls.Add(btnSair);
            panel1.Location = new Point(-4, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1276, 29);
            panel1.TabIndex = 9;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnSair
            // 
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnSair.FlatAppearance.MouseOverBackColor = Color.Red;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            btnSair.IconColor = Color.Black;
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnSair.IconSize = 30;
            btnSair.Location = new Point(1241, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(32, 32);
            btnSair.TabIndex = 15;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // pictureboxLogin
            // 
            pictureboxLogin.BackColor = Color.Transparent;
            pictureboxLogin.ForeColor = SystemColors.ControlText;
            pictureboxLogin.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            pictureboxLogin.IconColor = SystemColors.ControlText;
            pictureboxLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pictureboxLogin.IconSize = 30;
            pictureboxLogin.Location = new Point(823, 257);
            pictureboxLogin.Name = "pictureboxLogin";
            pictureboxLogin.Size = new Size(32, 32);
            pictureboxLogin.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureboxLogin.TabIndex = 10;
            pictureboxLogin.TabStop = false;
            // 
            // pictureBoxSenha
            // 
            pictureBoxSenha.BackColor = Color.Transparent;
            pictureBoxSenha.ForeColor = SystemColors.ControlText;
            pictureBoxSenha.IconChar = FontAwesome.Sharp.IconChar.Lock;
            pictureBoxSenha.IconColor = SystemColors.ControlText;
            pictureBoxSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pictureBoxSenha.IconSize = 30;
            pictureBoxSenha.Location = new Point(823, 391);
            pictureBoxSenha.Name = "pictureBoxSenha";
            pictureBoxSenha.Size = new Size(32, 32);
            pictureBoxSenha.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxSenha.TabIndex = 11;
            pictureBoxSenha.TabStop = false;
            // 
            // llblRecuperarSenha
            // 
            llblRecuperarSenha.AutoSize = true;
            llblRecuperarSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            llblRecuperarSenha.Location = new Point(927, 514);
            llblRecuperarSenha.Name = "llblRecuperarSenha";
            llblRecuperarSenha.Size = new Size(122, 21);
            llblRecuperarSenha.TabIndex = 12;
            llblRecuperarSenha.TabStop = true;
            llblRecuperarSenha.Text = "recuperar senha";
            llblRecuperarSenha.LinkClicked += llblRecuperarSenha_LinkClicked_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.stokeletro;
            pictureBox2.Location = new Point(111, 126);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(481, 481);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(84, 84, 84);
            iconPictureBox1.BackgroundImage = Properties.Resources.login;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 122;
            iconPictureBox1.Location = new Point(914, 59);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(122, 124);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox1.TabIndex = 14;
            iconPictureBox1.TabStop = false;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(1269, 749);
            Controls.Add(iconPictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(llblRecuperarSenha);
            Controls.Add(pictureBoxSenha);
            Controls.Add(pictureboxLogin);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnFazerLogin);
            Controls.Add(lblMensagemDeErro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginView";
            Text = "LoginView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureboxLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private Label lblMensagemDeErro;
        private FontAwesome.Sharp.IconButton btnFazerLogin;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox pictureboxLogin;
        private FontAwesome.Sharp.IconPictureBox pictureBoxSenha;
        private LinkLabel llblRecuperarSenha;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnSair;
        private System.Windows.Forms.Timer timer;
    }
}