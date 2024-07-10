namespace ClientApiJobs
{
    partial class Frm_RelatorioVagas
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
            dtgVagas = new DataGridView();
            menuStrip1 = new MenuStrip();
            label3 = new Label();
            lbquantidade = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgVagas).BeginInit();
            SuspendLayout();
            // 
            // dtgVagas
            // 
            dtgVagas.BackgroundColor = Color.Azure;
            dtgVagas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgVagas.Location = new Point(3, 81);
            dtgVagas.Name = "dtgVagas";
            dtgVagas.RowTemplate.Height = 25;
            dtgVagas.Size = new Size(719, 212);
            dtgVagas.TabIndex = 2;
            dtgVagas.CellDoubleClick += dtgVagas_CellDoubleClick;
            dtgVagas.CellFormatting += dtgVagas_CellFormatting;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateGray;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(728, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 31);
            label3.Name = "label3";
            label3.Size = new Size(580, 37);
            label3.TabIndex = 11;
            label3.Text = "TOTAL DE VAGAS REGISTRADAS PELA EMPRESA";
            // 
            // lbquantidade
            // 
            lbquantidade.AutoSize = true;
            lbquantidade.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbquantidade.ForeColor = Color.Red;
            lbquantidade.Location = new Point(606, 304);
            lbquantidade.Name = "lbquantidade";
            lbquantidade.Size = new Size(15, 19);
            lbquantidade.TabIndex = 18;
            lbquantidade.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(553, 304);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 17;
            label1.Text = "TOTAL:";
            // 
            // Frm_RelatorioVagas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(728, 332);
            Controls.Add(lbquantidade);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(menuStrip1);
            Controls.Add(dtgVagas);
            MaximizeBox = false;
            Name = "Frm_RelatorioVagas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RELATÓRIO DE VAGAS";
            Load += Frm_RelatorioVagas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgVagas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgVagas;
        private MenuStrip menuStrip1;
        private Label label3;
        private Label lbquantidade;
        private Label label1;
    }
}