namespace StockEletro.Desktop.Tela.Autenticacao
{
    partial class InserirEmail
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
            txtEmail = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnConfirma = new FontAwesome.Sharp.IconButton();
            btnCancela = new FontAwesome.Sharp.IconButton();
            btnSair = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(283, 101);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 23);
            txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(252, 44);
            label1.Name = "label1";
            label1.Size = new Size(276, 25);
            label1.TabIndex = 1;
            label1.Text = "Insira o e-mail de recuperação:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.stokeletro;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 279);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnConfirma
            // 
            btnConfirma.BackColor = Color.FromArgb(1, 104, 181);
            btnConfirma.FlatAppearance.BorderSize = 0;
            btnConfirma.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 17, 255);
            btnConfirma.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 17, 157);
            btnConfirma.FlatStyle = FlatStyle.Flat;
            btnConfirma.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnConfirma.IconColor = Color.Black;
            btnConfirma.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnConfirma.IconSize = 25;
            btnConfirma.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirma.Location = new Point(283, 157);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(106, 32);
            btnConfirma.TabIndex = 5;
            btnConfirma.Text = "CONFIRMA";
            btnConfirma.TextAlign = ContentAlignment.MiddleLeft;
            btnConfirma.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirma.UseVisualStyleBackColor = false;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // btnCancela
            // 
            btnCancela.BackColor = Color.FromArgb(249, 137, 71);
            btnCancela.FlatAppearance.BorderSize = 0;
            btnCancela.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 147, 21);
            btnCancela.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 101, 33);
            btnCancela.FlatStyle = FlatStyle.Flat;
            btnCancela.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            btnCancela.IconColor = Color.Black;
            btnCancela.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCancela.IconSize = 25;
            btnCancela.Location = new Point(395, 157);
            btnCancela.Name = "btnCancela";
            btnCancela.Size = new Size(106, 32);
            btnCancela.TabIndex = 6;
            btnCancela.Text = "CANCELAR";
            btnCancela.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancela.UseVisualStyleBackColor = false;
            btnCancela.Click += btnCancela_Click;
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
            btnSair.Location = new Point(496, -1);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(32, 32);
            btnSair.TabIndex = 16;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // InserirEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(527, 276);
            Controls.Add(btnSair);
            Controls.Add(btnCancela);
            Controls.Add(btnConfirma);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InserirEmail";
            Text = "InserirEmail";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label label1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnConfirma;
        private FontAwesome.Sharp.IconButton btnCancela;
        private FontAwesome.Sharp.IconButton btnSair;
    }
}