namespace StockEletro.Desktop.Tela.Produtos
{
    partial class ProdutoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoView));
            txtNome = new TextBox();
            txtSku = new TextBox();
            txtPreco = new TextBox();
            txtEstoqueAtual = new TextBox();
            txtNivelMinimo = new TextBox();
            txtPesquisa = new TextBox();
            cbCategoria = new ComboBox();
            cbSubCategoria = new ComboBox();
            cbSubCategoriaPesquisa = new ComboBox();
            cbCategoriaPesquisa = new ComboBox();
            dvgProduto = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label12 = new Label();
            chkStatus = new CheckBox();
            label13 = new Label();
            btnCadastrar = new FontAwesome.Sharp.IconButton();
            btnRecarrega = new FontAwesome.Sharp.IconButton();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            btnFiltra = new FontAwesome.Sharp.IconButton();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCategoria = new DataGridViewTextBoxColumn();
            ColumnPreco = new DataGridViewTextBoxColumn();
            ColumnEstoque = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ColumnEditar = new DataGridViewImageColumn();
            ColumnExcluir = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dvgProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(22, 139);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(270, 29);
            txtNome.TabIndex = 0;
            // 
            // txtSku
            // 
            txtSku.Location = new Point(426, 141);
            txtSku.Name = "txtSku";
            txtSku.Size = new Size(166, 29);
            txtSku.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(641, 141);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(104, 29);
            txtPreco.TabIndex = 2;
            // 
            // txtEstoqueAtual
            // 
            txtEstoqueAtual.Location = new Point(488, 219);
            txtEstoqueAtual.Name = "txtEstoqueAtual";
            txtEstoqueAtual.Size = new Size(104, 29);
            txtEstoqueAtual.TabIndex = 5;
            // 
            // txtNivelMinimo
            // 
            txtNivelMinimo.Location = new Point(788, 139);
            txtNivelMinimo.Name = "txtNivelMinimo";
            txtNivelMinimo.Size = new Size(104, 29);
            txtNivelMinimo.TabIndex = 6;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(13, 349);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(209, 29);
            txtPesquisa.TabIndex = 7;
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.FlatStyle = FlatStyle.Popup;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.ImeMode = ImeMode.NoControl;
            cbCategoria.Location = new Point(22, 219);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(209, 29);
            cbCategoria.TabIndex = 10;
            // 
            // cbSubCategoria
            // 
            cbSubCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubCategoria.FlatStyle = FlatStyle.Popup;
            cbSubCategoria.FormattingEnabled = true;
            cbSubCategoria.ImeMode = ImeMode.NoControl;
            cbSubCategoria.Location = new Point(256, 219);
            cbSubCategoria.Name = "cbSubCategoria";
            cbSubCategoria.Size = new Size(193, 29);
            cbSubCategoria.TabIndex = 11;
            // 
            // cbSubCategoriaPesquisa
            // 
            cbSubCategoriaPesquisa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubCategoriaPesquisa.FlatStyle = FlatStyle.Popup;
            cbSubCategoriaPesquisa.FormattingEnabled = true;
            cbSubCategoriaPesquisa.ImeMode = ImeMode.NoControl;
            cbSubCategoriaPesquisa.Location = new Point(478, 349);
            cbSubCategoriaPesquisa.Name = "cbSubCategoriaPesquisa";
            cbSubCategoriaPesquisa.Size = new Size(193, 29);
            cbSubCategoriaPesquisa.TabIndex = 14;
            // 
            // cbCategoriaPesquisa
            // 
            cbCategoriaPesquisa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoriaPesquisa.FlatStyle = FlatStyle.Popup;
            cbCategoriaPesquisa.FormattingEnabled = true;
            cbCategoriaPesquisa.ImeMode = ImeMode.NoControl;
            cbCategoriaPesquisa.Location = new Point(244, 349);
            cbCategoriaPesquisa.Name = "cbCategoriaPesquisa";
            cbCategoriaPesquisa.Size = new Size(209, 29);
            cbCategoriaPesquisa.TabIndex = 13;
            // 
            // dvgProduto
            // 
            dvgProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProduto.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome, ColumnCategoria, ColumnPreco, ColumnEstoque, Column1, ColumnEditar, ColumnExcluir });
            dvgProduto.Location = new Point(12, 394);
            dvgProduto.Name = "dvgProduto";
            dvgProduto.ReadOnly = true;
            dvgProduto.RowHeadersVisible = false;
            dvgProduto.RowTemplate.Height = 25;
            dvgProduto.Size = new Size(1052, 246);
            dvgProduto.TabIndex = 0;
            dvgProduto.CellContentDoubleClick += dvgProduto_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 191);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 17;
            label1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 191);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 18;
            label2.Text = "Subcategoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 321);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 20;
            label3.Text = "Subcategoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(244, 321);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 19;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 111);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 21;
            label5.Text = "Nome";
            // 
            // label6
            // 
            label6.Location = new Point(425, 113);
            label6.Name = "label6";
            label6.Size = new Size(49, 21);
            label6.TabIndex = 22;
            label6.Text = "SKU";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(641, 112);
            label7.Name = "label7";
            label7.Size = new Size(49, 21);
            label7.TabIndex = 23;
            label7.Text = "Preço";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 321);
            label8.Name = "label8";
            label8.Size = new Size(76, 21);
            label8.TabIndex = 24;
            label8.Text = "Pesquisar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(788, 112);
            label9.Name = "label9";
            label9.Size = new Size(104, 21);
            label9.TabIndex = 27;
            label9.Text = "Nivel minimo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(488, 192);
            label12.Name = "label12";
            label12.Size = new Size(105, 21);
            label12.TabIndex = 28;
            label12.Text = "Estoque Atual";
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(324, 143);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(65, 25);
            chkStatus.TabIndex = 29;
            chkStatus.Text = "Ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(324, 113);
            label13.Name = "label13";
            label13.Size = new Size(52, 21);
            label13.TabIndex = 30;
            label13.Text = "Status";
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
            btnCadastrar.Location = new Point(758, 278);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(118, 35);
            btnCadastrar.TabIndex = 19;
            btnCadastrar.Text = "Cadastra";
            btnCadastrar.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnRecarrega
            // 
            btnRecarrega.BackColor = Color.FromArgb(157, 157, 157);
            btnRecarrega.FlatStyle = FlatStyle.Flat;
            btnRecarrega.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecarrega.ForeColor = Color.White;
            btnRecarrega.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            btnRecarrega.IconColor = Color.White;
            btnRecarrega.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnRecarrega.IconSize = 30;
            btnRecarrega.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecarrega.Location = new Point(1026, 356);
            btnRecarrega.Name = "btnRecarrega";
            btnRecarrega.Size = new Size(38, 32);
            btnRecarrega.TabIndex = 20;
            btnRecarrega.TextAlign = ContentAlignment.MiddleLeft;
            btnRecarrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRecarrega.UseVisualStyleBackColor = false;
            btnRecarrega.Click += btnRecarrega_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(249, 137, 71);
            label14.Location = new Point(20, 9);
            label14.Name = "label14";
            label14.Size = new Size(246, 54);
            label14.TabIndex = 22;
            label14.Text = "PRODUTOS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(249, 137, 71);
            pictureBox1.Location = new Point(30, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 10);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // btnFiltra
            // 
            btnFiltra.BackColor = Color.FromArgb(1, 104, 181);
            btnFiltra.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 167, 196);
            btnFiltra.FlatStyle = FlatStyle.Flat;
            btnFiltra.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltra.ForeColor = Color.White;
            btnFiltra.IconChar = FontAwesome.Sharp.IconChar.Filter;
            btnFiltra.IconColor = Color.White;
            btnFiltra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFiltra.IconSize = 30;
            btnFiltra.Location = new Point(677, 346);
            btnFiltra.Name = "btnFiltra";
            btnFiltra.Size = new Size(118, 36);
            btnFiltra.TabIndex = 31;
            btnFiltra.Text = "Filtrar";
            btnFiltra.TextAlign = ContentAlignment.MiddleLeft;
            btnFiltra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFiltra.UseVisualStyleBackColor = true;
            // 
            // ColumnId
            // 
            ColumnId.DataPropertyName = "Id";
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            ColumnId.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnId.HeaderText = "ID";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Width = 50;
            // 
            // ColumnNome
            // 
            ColumnNome.DataPropertyName = "Nome";
            dataGridViewCellStyle2.ForeColor = Color.Black;
            ColumnNome.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnNome.HeaderText = "Nome";
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            // 
            // ColumnCategoria
            // 
            ColumnCategoria.DataPropertyName = "CategoriaId";
            dataGridViewCellStyle3.ForeColor = Color.Black;
            ColumnCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnCategoria.HeaderText = "Categoria";
            ColumnCategoria.Name = "ColumnCategoria";
            ColumnCategoria.ReadOnly = true;
            // 
            // ColumnPreco
            // 
            ColumnPreco.DataPropertyName = "Preco";
            dataGridViewCellStyle4.ForeColor = Color.Black;
            ColumnPreco.DefaultCellStyle = dataGridViewCellStyle4;
            ColumnPreco.HeaderText = "Preço";
            ColumnPreco.Name = "ColumnPreco";
            ColumnPreco.ReadOnly = true;
            // 
            // ColumnEstoque
            // 
            ColumnEstoque.DataPropertyName = "EstoqueAtual";
            dataGridViewCellStyle5.ForeColor = Color.Black;
            ColumnEstoque.DefaultCellStyle = dataGridViewCellStyle5;
            ColumnEstoque.HeaderText = "Estoque";
            ColumnEstoque.Name = "ColumnEstoque";
            ColumnEstoque.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "NivelMinimo";
            dataGridViewCellStyle6.ForeColor = Color.Black;
            Column1.DefaultCellStyle = dataGridViewCellStyle6;
            Column1.HeaderText = "Nivel de Reposição";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // ColumnEditar
            // 
            ColumnEditar.HeaderText = "Editar";
            ColumnEditar.Image = Properties.Resources.icons8_editar_20;
            ColumnEditar.Name = "ColumnEditar";
            ColumnEditar.ReadOnly = true;
            ColumnEditar.Width = 60;
            // 
            // ColumnExcluir
            // 
            ColumnExcluir.HeaderText = "Deletar";
            ColumnExcluir.Image = (Image)resources.GetObject("ColumnExcluir.Image");
            ColumnExcluir.Name = "ColumnExcluir";
            ColumnExcluir.ReadOnly = true;
            ColumnExcluir.Width = 65;
            // 
            // ProdutoView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 66, 66);
            ClientSize = new Size(1092, 649);
            Controls.Add(btnFiltra);
            Controls.Add(pictureBox1);
            Controls.Add(label14);
            Controls.Add(btnRecarrega);
            Controls.Add(btnCadastrar);
            Controls.Add(label13);
            Controls.Add(chkStatus);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dvgProduto);
            Controls.Add(cbSubCategoriaPesquisa);
            Controls.Add(cbCategoriaPesquisa);
            Controls.Add(cbSubCategoria);
            Controls.Add(cbCategoria);
            Controls.Add(txtPesquisa);
            Controls.Add(txtNivelMinimo);
            Controls.Add(txtEstoqueAtual);
            Controls.Add(txtPreco);
            Controls.Add(txtSku);
            Controls.Add(txtNome);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ProdutoView";
            Text = "ProdutoView";
            Load += ProdutoView_Load;
            ((System.ComponentModel.ISupportInitialize)dvgProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtSku;
        private TextBox txtPreco;
        private TextBox txtEstoqueAtual;
        private TextBox txtNivelMinimo;
        private TextBox txtPesquisa;
        private Button btnSalvar;
        private Button btnRecarregar;
        private ComboBox cbCategoria;
        private ComboBox cbSubCategoria;
        private ComboBox cbSubCategoriaPesquisa;
        private ComboBox cbCategoriaPesquisa;
        private DataGridView dvgProduto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label12;
        private CheckBox chkStatus;
        private Label label13;
        private FontAwesome.Sharp.IconButton btnCadastrar;
        private FontAwesome.Sharp.IconButton btnRecarrega;
        private Label label14;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnFiltra;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnPreco;
        private DataGridViewTextBoxColumn ColumnEstoque;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewImageColumn ColumnEditar;
        private DataGridViewImageColumn ColumnExcluir;
    }
}