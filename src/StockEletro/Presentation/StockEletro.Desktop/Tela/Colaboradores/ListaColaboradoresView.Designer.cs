namespace StockEletro.Desktop.Tela.Colaboradores
{
    partial class ListaColaboradoresView
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
            txtNomeColaborador = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCpf = new MaskedTextBox();
            btnCarregarLista = new Button();
            dgvListaColaboradores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaColaboradores).BeginInit();
            SuspendLayout();
            // 
            // txtNomeColaborador
            // 
            txtNomeColaborador.Location = new Point(171, 64);
            txtNomeColaborador.Name = "txtNomeColaborador";
            txtNomeColaborador.Size = new Size(123, 23);
            txtNomeColaborador.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 67);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar por:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 67);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 67);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 3;
            label3.Text = "CPF";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(352, 64);
            txtCpf.Mask = "000.000.000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(97, 23);
            txtCpf.TabIndex = 4;
            // 
            // btnCarregarLista
            // 
            btnCarregarLista.Location = new Point(512, 106);
            btnCarregarLista.Name = "btnCarregarLista";
            btnCarregarLista.Size = new Size(112, 23);
            btnCarregarLista.TabIndex = 6;
            btnCarregarLista.Text = "Carregar Lista";
            btnCarregarLista.UseVisualStyleBackColor = true;
            btnCarregarLista.Click += btnCarregarLista_Click;
            // 
            // dgvListaColaboradores
            // 
            dgvListaColaboradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaColaboradores.Location = new Point(34, 135);
            dgvListaColaboradores.Name = "dgvListaColaboradores";
            dgvListaColaboradores.RowTemplate.Height = 25;
            dgvListaColaboradores.Size = new Size(643, 138);
            dgvListaColaboradores.TabIndex = 5;
            // 
            // ListaColaboradoresView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 351);
            Controls.Add(btnCarregarLista);
            Controls.Add(dgvListaColaboradores);
            Controls.Add(txtCpf);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNomeColaborador);
            Name = "ListaColaboradoresView";
            Text = "ListaColaboradoresView";
            Load += ListaColaboradoresView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaColaboradores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeColaborador;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox txtCpf;
        private Button btnCarregarLista;
        private DataGridView dgvListaColaboradores;
    }
}