namespace StockEletro.Desktop.Tela.Inicio
{
    partial class Inicio2View
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
            timerHoras = new System.Windows.Forms.Timer(components);
            lblHorario = new Label();
            SuspendLayout();
            // 
            // timerHoras
            // 
            timerHoras.Enabled = true;
            timerHoras.Tick += timerHoras_Tick;
            // 
            // lblHorario
            // 
            lblHorario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Snap ITC", 50.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHorario.ForeColor = Color.FromArgb(249, 137, 71);
            lblHorario.Location = new Point(415, 296);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(242, 86);
            lblHorario.TabIndex = 0;
            lblHorario.Text = "horas";
            lblHorario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Inicio2View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 66, 66);
            ClientSize = new Size(1092, 680);
            Controls.Add(lblHorario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio2View";
            Text = "Inicio2View";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerHoras;
        private Label lblHorario;
    }
}