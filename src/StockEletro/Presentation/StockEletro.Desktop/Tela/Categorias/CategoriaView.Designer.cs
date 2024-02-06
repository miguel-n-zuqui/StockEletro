namespace StockEletro.Desktop.Tela
{
    partial class CategoriaView
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaView));
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            chkStatusCategoria = new CheckBox();
            dgvSubCategoria = new DataGridView();
            ColumnIdSub = new DataGridViewTextBoxColumn();
            ColumnNomeSub = new DataGridViewTextBoxColumn();
            ColumnIdCategoria = new DataGridViewTextBoxColumn();
            ColumnStatusSub = new DataGridViewCheckBoxColumn();
            ColumnCriadoEmSub = new DataGridViewTextBoxColumn();
            ColumnEditarSub = new DataGridViewImageColumn();
            ColumnExcluirSub = new DataGridViewImageColumn();
            dgvCategoria = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCriadoEm = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewCheckBoxColumn();
            ColumnEditar = new DataGridViewImageColumn();
            ColumnExcluir = new DataGridViewImageColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            chkStatusSubCategoria = new CheckBox();
            label1 = new Label();
            txtNomeSubcategoria = new TextBox();
            cbCategoria = new ComboBox();
            label4 = new Label();
            txtPesquisCategoria = new TextBox();
            label5 = new Label();
            txtPesquisaSubCategoria = new TextBox();
            btnCadastrarCategoria = new FontAwesome.Sharp.IconButton();
            btnCadastrarSubCategoria = new FontAwesome.Sharp.IconButton();
            btnRecarrega = new FontAwesome.Sharp.IconButton();
            btnRecarregaSub = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvSubCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 138);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(226, 414);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 3;
            label3.Text = "Categoria";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(42, 197);
            txtNome.Margin = new Padding(4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(133, 29);
            txtNome.TabIndex = 4;
            // 
            // chkStatusCategoria
            // 
            chkStatusCategoria.AutoSize = true;
            chkStatusCategoria.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            chkStatusCategoria.ForeColor = Color.White;
            chkStatusCategoria.Location = new Point(217, 192);
            chkStatusCategoria.Name = "chkStatusCategoria";
            chkStatusCategoria.Size = new Size(81, 29);
            chkStatusCategoria.TabIndex = 6;
            chkStatusCategoria.Text = "Status";
            chkStatusCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvSubCategoria
            // 
            dgvSubCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSubCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubCategoria.Columns.AddRange(new DataGridViewColumn[] { ColumnIdSub, ColumnNomeSub, ColumnIdCategoria, ColumnStatusSub, ColumnCriadoEmSub, ColumnEditarSub, ColumnExcluirSub });
            dgvSubCategoria.Location = new Point(510, 413);
            dgvSubCategoria.Name = "dgvSubCategoria";
            dgvSubCategoria.RowHeadersVisible = false;
            dgvSubCategoria.RowTemplate.Height = 25;
            dgvSubCategoria.Size = new Size(570, 224);
            dgvSubCategoria.TabIndex = 1;
            dgvSubCategoria.CellContentDoubleClick += dgvSubCategoria_CellContentDoubleClick;
            // 
            // ColumnIdSub
            // 
            ColumnIdSub.DataPropertyName = "Id";
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            ColumnIdSub.DefaultCellStyle = dataGridViewCellStyle10;
            ColumnIdSub.HeaderText = "ID";
            ColumnIdSub.Name = "ColumnIdSub";
            ColumnIdSub.Width = 50;
            // 
            // ColumnNomeSub
            // 
            ColumnNomeSub.DataPropertyName = "Nome";
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            ColumnNomeSub.DefaultCellStyle = dataGridViewCellStyle11;
            ColumnNomeSub.HeaderText = "Nome";
            ColumnNomeSub.Name = "ColumnNomeSub";
            // 
            // ColumnIdCategoria
            // 
            ColumnIdCategoria.DataPropertyName = "CategoriaId";
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            ColumnIdCategoria.DefaultCellStyle = dataGridViewCellStyle12;
            ColumnIdCategoria.HeaderText = "ID Categoria";
            ColumnIdCategoria.Name = "ColumnIdCategoria";
            // 
            // ColumnStatusSub
            // 
            ColumnStatusSub.DataPropertyName = "Status";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.ForeColor = Color.Black;
            dataGridViewCellStyle13.NullValue = false;
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            ColumnStatusSub.DefaultCellStyle = dataGridViewCellStyle13;
            ColumnStatusSub.HeaderText = "Status";
            ColumnStatusSub.Name = "ColumnStatusSub";
            ColumnStatusSub.Resizable = DataGridViewTriState.True;
            ColumnStatusSub.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnStatusSub.Width = 70;
            // 
            // ColumnCriadoEmSub
            // 
            ColumnCriadoEmSub.DataPropertyName = "CriadoEm";
            dataGridViewCellStyle14.ForeColor = Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            ColumnCriadoEmSub.DefaultCellStyle = dataGridViewCellStyle14;
            ColumnCriadoEmSub.HeaderText = "Data de cadastro";
            ColumnCriadoEmSub.Name = "ColumnCriadoEmSub";
            // 
            // ColumnEditarSub
            // 
            ColumnEditarSub.HeaderText = "Editar";
            ColumnEditarSub.Image = Properties.Resources.icons8_editar_20;
            ColumnEditarSub.Name = "ColumnEditarSub";
            ColumnEditarSub.Width = 60;
            // 
            // ColumnExcluirSub
            // 
            ColumnExcluirSub.HeaderText = "Deletar";
            ColumnExcluirSub.Image = Properties.Resources.icons8_excluir_20__1_;
            ColumnExcluirSub.Name = "ColumnExcluirSub";
            ColumnExcluirSub.Width = 65;
            // 
            // dgvCategoria
            // 
            dgvCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome, ColumnCriadoEm, ColumnStatus, ColumnEditar, ColumnExcluir });
            dgvCategoria.Location = new Point(510, 105);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.ReadOnly = true;
            dgvCategoria.RowHeadersVisible = false;
            dgvCategoria.RowTemplate.Height = 25;
            dgvCategoria.Size = new Size(570, 224);
            dgvCategoria.TabIndex = 0;
            dgvCategoria.CellContentDoubleClick += dgvCategoria_CellContentDoubleClick;
            // 
            // ColumnId
            // 
            ColumnId.DataPropertyName = "Id";
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = Color.White;
            dataGridViewCellStyle15.SelectionForeColor = Color.Black;
            ColumnId.DefaultCellStyle = dataGridViewCellStyle15;
            ColumnId.HeaderText = "ID";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Width = 50;
            // 
            // ColumnNome
            // 
            ColumnNome.DataPropertyName = "Nome";
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = Color.White;
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            ColumnNome.DefaultCellStyle = dataGridViewCellStyle16;
            ColumnNome.HeaderText = "Nome";
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            // 
            // ColumnCriadoEm
            // 
            ColumnCriadoEm.DataPropertyName = "CriadoEm";
            dataGridViewCellStyle17.ForeColor = Color.Black;
            dataGridViewCellStyle17.SelectionForeColor = Color.Black;
            ColumnCriadoEm.DefaultCellStyle = dataGridViewCellStyle17;
            ColumnCriadoEm.HeaderText = "Data de cadastro";
            ColumnCriadoEm.Name = "ColumnCriadoEm";
            ColumnCriadoEm.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            ColumnStatus.DataPropertyName = "Status";
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.ForeColor = Color.Black;
            dataGridViewCellStyle18.NullValue = false;
            dataGridViewCellStyle18.SelectionForeColor = Color.Black;
            ColumnStatus.DefaultCellStyle = dataGridViewCellStyle18;
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.Name = "ColumnStatus";
            ColumnStatus.ReadOnly = true;
            ColumnStatus.Resizable = DataGridViewTriState.True;
            ColumnStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnStatus.Width = 70;
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // chkStatusSubCategoria
            // 
            chkStatusSubCategoria.AutoSize = true;
            chkStatusSubCategoria.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            chkStatusSubCategoria.ForeColor = Color.White;
            chkStatusSubCategoria.Location = new Point(410, 457);
            chkStatusSubCategoria.Name = "chkStatusSubCategoria";
            chkStatusSubCategoria.Size = new Size(81, 29);
            chkStatusSubCategoria.TabIndex = 9;
            chkStatusSubCategoria.Text = "Status";
            chkStatusSubCategoria.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 386);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 10;
            label1.Text = "Nome";
            // 
            // txtNomeSubcategoria
            // 
            txtNomeSubcategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeSubcategoria.Location = new Point(45, 457);
            txtNomeSubcategoria.Margin = new Padding(4);
            txtNomeSubcategoria.Name = "txtNomeSubcategoria";
            txtNomeSubcategoria.Size = new Size(174, 29);
            txtNomeSubcategoria.TabIndex = 11;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(226, 457);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(166, 29);
            cbCategoria.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(510, 27);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(172, 25);
            label4.TabIndex = 14;
            label4.Text = "Procurar Categoria";
            // 
            // txtPesquisCategoria
            // 
            txtPesquisCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisCategoria.Location = new Point(510, 71);
            txtPesquisCategoria.Margin = new Padding(4);
            txtPesquisCategoria.Name = "txtPesquisCategoria";
            txtPesquisCategoria.Size = new Size(133, 29);
            txtPesquisCategoria.TabIndex = 15;
            txtPesquisCategoria.TextChanged += txtPesquisCategoria_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(510, 346);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(204, 25);
            label5.TabIndex = 16;
            label5.Text = "Procurar SubCategoria";
            // 
            // txtPesquisaSubCategoria
            // 
            txtPesquisaSubCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisaSubCategoria.Location = new Point(510, 382);
            txtPesquisaSubCategoria.Margin = new Padding(4);
            txtPesquisaSubCategoria.Name = "txtPesquisaSubCategoria";
            txtPesquisaSubCategoria.Size = new Size(168, 29);
            txtPesquisaSubCategoria.TabIndex = 17;
            txtPesquisaSubCategoria.TextChanged += txtPesquisaSubCategoria_TextChanged;
            // 
            // btnCadastrarCategoria
            // 
            btnCadastrarCategoria.BackColor = Color.FromArgb(1, 104, 181);
            btnCadastrarCategoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 167, 196);
            btnCadastrarCategoria.FlatStyle = FlatStyle.Flat;
            btnCadastrarCategoria.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrarCategoria.ForeColor = Color.White;
            btnCadastrarCategoria.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnCadastrarCategoria.IconColor = Color.White;
            btnCadastrarCategoria.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCadastrarCategoria.IconSize = 30;
            btnCadastrarCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrarCategoria.Location = new Point(320, 192);
            btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            btnCadastrarCategoria.Size = new Size(118, 32);
            btnCadastrarCategoria.TabIndex = 18;
            btnCadastrarCategoria.Text = "Cadastra";
            btnCadastrarCategoria.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastrarCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrarCategoria.UseVisualStyleBackColor = false;
            btnCadastrarCategoria.Click += btnCadastrarCategoria_Click;
            // 
            // btnCadastrarSubCategoria
            // 
            btnCadastrarSubCategoria.BackColor = Color.FromArgb(1, 104, 181);
            btnCadastrarSubCategoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 167, 196);
            btnCadastrarSubCategoria.FlatStyle = FlatStyle.Flat;
            btnCadastrarSubCategoria.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrarSubCategoria.ForeColor = Color.White;
            btnCadastrarSubCategoria.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnCadastrarSubCategoria.IconColor = Color.White;
            btnCadastrarSubCategoria.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCadastrarSubCategoria.IconSize = 30;
            btnCadastrarSubCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrarSubCategoria.Location = new Point(45, 513);
            btnCadastrarSubCategoria.Name = "btnCadastrarSubCategoria";
            btnCadastrarSubCategoria.Size = new Size(118, 32);
            btnCadastrarSubCategoria.TabIndex = 19;
            btnCadastrarSubCategoria.Text = "Cadastra";
            btnCadastrarSubCategoria.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastrarSubCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrarSubCategoria.UseVisualStyleBackColor = false;
            btnCadastrarSubCategoria.Click += btnCadastrarSubCategoria_Click;
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
            btnRecarrega.Location = new Point(1038, 58);
            btnRecarrega.Name = "btnRecarrega";
            btnRecarrega.Size = new Size(42, 32);
            btnRecarrega.TabIndex = 20;
            btnRecarrega.TextAlign = ContentAlignment.MiddleLeft;
            btnRecarrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRecarrega.UseVisualStyleBackColor = false;
            btnRecarrega.Click += btnRecarrega_Click;
            // 
            // btnRecarregaSub
            // 
            btnRecarregaSub.BackColor = Color.FromArgb(157, 157, 157);
            btnRecarregaSub.FlatStyle = FlatStyle.Flat;
            btnRecarregaSub.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecarregaSub.ForeColor = Color.White;
            btnRecarregaSub.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            btnRecarregaSub.IconColor = Color.White;
            btnRecarregaSub.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnRecarregaSub.IconSize = 30;
            btnRecarregaSub.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecarregaSub.Location = new Point(1038, 370);
            btnRecarregaSub.Name = "btnRecarregaSub";
            btnRecarregaSub.Size = new Size(42, 32);
            btnRecarregaSub.TabIndex = 21;
            btnRecarregaSub.TextAlign = ContentAlignment.MiddleLeft;
            btnRecarregaSub.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRecarregaSub.UseVisualStyleBackColor = false;
            btnRecarregaSub.Click += btnRecarregaSub_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(249, 137, 71);
            label6.Location = new Point(36, 18);
            label6.Name = "label6";
            label6.Size = new Size(279, 54);
            label6.TabIndex = 22;
            label6.Text = "CATEGORIAS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(249, 137, 71);
            pictureBox1.Location = new Point(45, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 10);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // CategoriaView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 66, 66);
            ClientSize = new Size(1092, 649);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(btnRecarregaSub);
            Controls.Add(btnRecarrega);
            Controls.Add(btnCadastrarSubCategoria);
            Controls.Add(btnCadastrarCategoria);
            Controls.Add(cbCategoria);
            Controls.Add(label1);
            Controls.Add(txtNomeSubcategoria);
            Controls.Add(chkStatusSubCategoria);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(chkStatusCategoria);
            Controls.Add(txtPesquisaSubCategoria);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPesquisCategoria);
            Controls.Add(dgvSubCategoria);
            Controls.Add(dgvCategoria);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "CategoriaView";
            Text = "CategoriaView";
            Load += CategoriaView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private CheckBox chkStatusCategoria;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvCategoria;
        private DataGridView dgvSubCategoria;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox textBox4;
        private Label label5;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button4;
        private Button button3;
        private CheckBox chkStatusSubCategoria;
        private Label label1;
        private TextBox txtNomeSubcategoria;
        private ComboBox cbCategoria;
        private TextBox txtPesquisCategoria;
        private TextBox txtPesquisaSubCategoria;
        private FontAwesome.Sharp.IconButton btnCadastrarCategoria;
        private FontAwesome.Sharp.IconButton btnCadastrarSubCategoria;
        private FontAwesome.Sharp.IconButton btnRecarrega;
        private FontAwesome.Sharp.IconButton btnRecarregaSub;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCriadoEm;
        private DataGridViewCheckBoxColumn ColumnStatus;
        private DataGridViewImageColumn ColumnEditar;
        private DataGridViewImageColumn ColumnExcluir;
        private DataGridViewTextBoxColumn ColumnIdSub;
        private DataGridViewTextBoxColumn ColumnNomeSub;
        private DataGridViewTextBoxColumn ColumnIdCategoria;
        private DataGridViewCheckBoxColumn ColumnStatusSub;
        private DataGridViewTextBoxColumn ColumnCriadoEmSub;
        private DataGridViewImageColumn ColumnEditarSub;
        private DataGridViewImageColumn ColumnExcluirSub;
        private Label label6;
        private PictureBox pictureBox1;
    }
}