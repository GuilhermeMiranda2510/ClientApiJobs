namespace ClientApiJobs.Forms.Candidato
{
    partial class Frm_CandidatoxVagas
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
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            dtgMinhasCandidaturas = new DataGridView();
            lbquantidade = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgMinhasCandidaturas).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(197, 29);
            label3.Name = "label3";
            label3.Size = new Size(318, 37);
            label3.TabIndex = 17;
            label3.Text = "MINHAS CANDIDATURAS";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateGray;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(693, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // dtgMinhasCandidaturas
            // 
            dtgMinhasCandidaturas.AllowUserToAddRows = false;
            dtgMinhasCandidaturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgMinhasCandidaturas.BackgroundColor = Color.Azure;
            dtgMinhasCandidaturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMinhasCandidaturas.Location = new Point(12, 70);
            dtgMinhasCandidaturas.Name = "dtgMinhasCandidaturas";
            dtgMinhasCandidaturas.ReadOnly = true;
            dtgMinhasCandidaturas.RowTemplate.Height = 25;
            dtgMinhasCandidaturas.Size = new Size(669, 223);
            dtgMinhasCandidaturas.TabIndex = 15;
            // 
            // lbquantidade
            // 
            lbquantidade.AutoSize = true;
            lbquantidade.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbquantidade.ForeColor = Color.Red;
            lbquantidade.Location = new Point(583, 296);
            lbquantidade.Name = "lbquantidade";
            lbquantidade.Size = new Size(15, 19);
            lbquantidade.TabIndex = 19;
            lbquantidade.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(530, 296);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 18;
            label1.Text = "TOTAL:";
            // 
            // Frm_CandidatoxVagas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 321);
            Controls.Add(lbquantidade);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(menuStrip1);
            Controls.Add(dtgMinhasCandidaturas);
            MaximizeBox = false;
            Name = "Frm_CandidatoxVagas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MINHAS CANDIDATURAS";
            Load += Frm_CandidatoxVagas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgMinhasCandidaturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private MenuStrip menuStrip1;
        private DataGridView dtgMinhasCandidaturas;
        private Label lbquantidade;
        private Label label1;
    }
}