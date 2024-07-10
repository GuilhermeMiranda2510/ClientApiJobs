namespace ClientApiJobs.Forms.Candidato
{
    partial class Frm_VagasDisponveis
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
            dtgVagasDisponiveis = new DataGridView();
            label1 = new Label();
            lbquantidade = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgVagasDisponiveis).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(217, 26);
            label3.Name = "label3";
            label3.Size = new Size(259, 37);
            label3.TabIndex = 14;
            label3.Text = "VAGAS DISPONIVEIS";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateGray;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(693, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // dtgVagasDisponiveis
            // 
            dtgVagasDisponiveis.AllowUserToAddRows = false;
            dtgVagasDisponiveis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgVagasDisponiveis.BackgroundColor = Color.Azure;
            dtgVagasDisponiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgVagasDisponiveis.Location = new Point(12, 66);
            dtgVagasDisponiveis.Name = "dtgVagasDisponiveis";
            dtgVagasDisponiveis.ReadOnly = true;
            dtgVagasDisponiveis.RowTemplate.Height = 25;
            dtgVagasDisponiveis.Size = new Size(669, 212);
            dtgVagasDisponiveis.TabIndex = 12;
            dtgVagasDisponiveis.CellDoubleClick += dtgVagasDisponiveis_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(559, 285);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 15;
            label1.Text = "TOTAL:";
            // 
            // lbquantidade
            // 
            lbquantidade.AutoSize = true;
            lbquantidade.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbquantidade.ForeColor = Color.Red;
            lbquantidade.Location = new Point(612, 285);
            lbquantidade.Name = "lbquantidade";
            lbquantidade.Size = new Size(15, 19);
            lbquantidade.TabIndex = 16;
            lbquantidade.Text = "-";
            // 
            // Frm_VagasDisponveis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 309);
            Controls.Add(lbquantidade);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(menuStrip1);
            Controls.Add(dtgVagasDisponiveis);
            MaximizeBox = false;
            Name = "Frm_VagasDisponveis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VAGAS DISPONIVEIS";
            Load += Frm_VagasxCandidato_Load;
            ((System.ComponentModel.ISupportInitialize)dtgVagasDisponiveis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private MenuStrip menuStrip1;
        private DataGridView dtgVagasDisponiveis;
        private Label label1;
        private Label lbquantidade;
    }
}