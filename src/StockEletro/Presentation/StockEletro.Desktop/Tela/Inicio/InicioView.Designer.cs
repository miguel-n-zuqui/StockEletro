namespace StockEletro.Desktop.Tela.Inicio
{
    partial class InicioView
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
            panelCima = new Panel();
            lblNomeTela = new Label();
            btnFechar = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            panelLateral = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            btnUsuario = new FontAwesome.Sharp.IconButton();
            bntColaborador = new FontAwesome.Sharp.IconButton();
            btnCliente = new FontAwesome.Sharp.IconButton();
            btnProduto = new FontAwesome.Sharp.IconButton();
            bntCategoria = new FontAwesome.Sharp.IconButton();
            btnEstoque = new FontAwesome.Sharp.IconButton();
            panelCentral = new Panel();
            panelCima.SuspendLayout();
            panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelCima
            // 
            panelCima.BackColor = Color.FromArgb(32, 31, 31);
            panelCima.Controls.Add(lblNomeTela);
            panelCima.Controls.Add(btnFechar);
            panelCima.Dock = DockStyle.Top;
            panelCima.Location = new Point(0, 0);
            panelCima.Name = "panelCima";
            panelCima.Size = new Size(1292, 39);
            panelCima.TabIndex = 1;
            // 
            // lblNomeTela
            // 
            lblNomeTela.AutoSize = true;
            lblNomeTela.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeTela.ForeColor = Color.White;
            lblNomeTela.Location = new Point(203, 9);
            lblNomeTela.Name = "lblNomeTela";
            lblNomeTela.Size = new Size(61, 25);
            lblNomeTela.TabIndex = 8;
            lblNomeTela.Text = "label1";
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.IconChar = FontAwesome.Sharp.IconChar.CircleStop;
            btnFechar.IconColor = Color.Black;
            btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFechar.IconSize = 30;
            btnFechar.Location = new Point(1250, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(42, 49);
            btnFechar.TabIndex = 7;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnInicio
            // 
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.White;
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            btnInicio.IconColor = Color.White;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInicio.IconSize = 30;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(3, 109);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(197, 49);
            btnInicio.TabIndex = 4;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.FromArgb(16, 16, 16);
            panelLateral.Controls.Add(pictureBox1);
            panelLateral.Controls.Add(btnInicio);
            panelLateral.Controls.Add(btnUsuario);
            panelLateral.Controls.Add(bntColaborador);
            panelLateral.Controls.Add(btnCliente);
            panelLateral.Controls.Add(btnProduto);
            panelLateral.Controls.Add(bntCategoria);
            panelLateral.Controls.Add(btnEstoque);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 39);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(200, 680);
            panelLateral.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.stokeletro;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 100);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.Cursor = Cursors.Hand;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnUsuario.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuario.ForeColor = Color.White;
            btnUsuario.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            btnUsuario.IconColor = Color.White;
            btnUsuario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnUsuario.IconSize = 30;
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.Location = new Point(3, 164);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(197, 49);
            btnUsuario.TabIndex = 7;
            btnUsuario.Text = "Usuario";
            btnUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // bntColaborador
            // 
            bntColaborador.Cursor = Cursors.Hand;
            bntColaborador.FlatAppearance.BorderSize = 0;
            bntColaborador.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            bntColaborador.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            bntColaborador.FlatStyle = FlatStyle.Flat;
            bntColaborador.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            bntColaborador.ForeColor = Color.White;
            bntColaborador.IconChar = FontAwesome.Sharp.IconChar.HandshakeAlt;
            bntColaborador.IconColor = Color.White;
            bntColaborador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntColaborador.IconSize = 30;
            bntColaborador.ImageAlign = ContentAlignment.MiddleLeft;
            bntColaborador.Location = new Point(3, 219);
            bntColaborador.Name = "bntColaborador";
            bntColaborador.Size = new Size(197, 49);
            bntColaborador.TabIndex = 8;
            bntColaborador.Text = "Colaborador";
            bntColaborador.TextAlign = ContentAlignment.MiddleLeft;
            bntColaborador.TextImageRelation = TextImageRelation.ImageBeforeText;
            bntColaborador.UseVisualStyleBackColor = true;
            bntColaborador.Click += bntColaborador_Click;
            // 
            // btnCliente
            // 
            btnCliente.Cursor = Cursors.Hand;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnCliente.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCliente.ForeColor = Color.White;
            btnCliente.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            btnCliente.IconColor = Color.White;
            btnCliente.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCliente.IconSize = 30;
            btnCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCliente.Location = new Point(3, 274);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(197, 49);
            btnCliente.TabIndex = 9;
            btnCliente.Text = "Cliente";
            btnCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnProduto
            // 
            btnProduto.Cursor = Cursors.Hand;
            btnProduto.FlatAppearance.BorderSize = 0;
            btnProduto.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnProduto.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnProduto.FlatStyle = FlatStyle.Flat;
            btnProduto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnProduto.ForeColor = Color.White;
            btnProduto.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnProduto.IconColor = Color.White;
            btnProduto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnProduto.IconSize = 30;
            btnProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduto.Location = new Point(3, 329);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(197, 49);
            btnProduto.TabIndex = 10;
            btnProduto.Text = "Produto";
            btnProduto.TextAlign = ContentAlignment.MiddleLeft;
            btnProduto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduto.UseVisualStyleBackColor = true;
            btnProduto.Click += btnProduto_Click;
            // 
            // bntCategoria
            // 
            bntCategoria.Cursor = Cursors.Hand;
            bntCategoria.FlatAppearance.BorderSize = 0;
            bntCategoria.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            bntCategoria.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            bntCategoria.FlatStyle = FlatStyle.Flat;
            bntCategoria.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            bntCategoria.ForeColor = Color.White;
            bntCategoria.IconChar = FontAwesome.Sharp.IconChar.Tags;
            bntCategoria.IconColor = Color.White;
            bntCategoria.IconFont = FontAwesome.Sharp.IconFont.Solid;
            bntCategoria.IconSize = 30;
            bntCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            bntCategoria.Location = new Point(3, 384);
            bntCategoria.Name = "bntCategoria";
            bntCategoria.Size = new Size(197, 49);
            bntCategoria.TabIndex = 11;
            bntCategoria.Text = "Categoria";
            bntCategoria.TextAlign = ContentAlignment.MiddleLeft;
            bntCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            bntCategoria.UseVisualStyleBackColor = true;
            bntCategoria.Click += bntCategoria_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.Cursor = Cursors.Hand;
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnEstoque.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstoque.ForeColor = Color.White;
            btnEstoque.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            btnEstoque.IconColor = Color.White;
            btnEstoque.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEstoque.IconSize = 30;
            btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoque.Location = new Point(3, 439);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(197, 49);
            btnEstoque.TabIndex = 12;
            btnEstoque.Text = "Estoque";
            btnEstoque.TextAlign = ContentAlignment.MiddleLeft;
            btnEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // panelCentral
            // 
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(200, 39);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1092, 680);
            panelCentral.TabIndex = 7;
            // 
            // InicioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 719);
            Controls.Add(panelCentral);
            Controls.Add(panelLateral);
            Controls.Add(panelCima);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InicioView";
            Text = "InicioView";
            Load += InicioView_Load;
            panelCima.ResumeLayout(false);
            panelCima.PerformLayout();
            panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelCima;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FlowLayoutPanel panelLateral;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private FontAwesome.Sharp.IconButton bntColaborador;
        private FontAwesome.Sharp.IconButton btnCliente;
        private FontAwesome.Sharp.IconButton btnProduto;
        private FontAwesome.Sharp.IconButton bntCategoria;
        private FontAwesome.Sharp.IconButton btnEstoque;
        private FontAwesome.Sharp.IconButton btnFechar;
        private PictureBox pictureBox1;
        private Panel panelCentral;
        private Label lblNomeTela;
    }
}
