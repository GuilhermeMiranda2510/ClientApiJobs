namespace ClientApiJobs.Forms.Empresa
{
    partial class Frm_ListarCandidatosPorVaga
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
            dtgListaCandidatosVaga = new DataGridView();
            lbquantidade = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgListaCandidatosVaga).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(185, 29);
            label3.Name = "label3";
            label3.Size = new Size(395, 37);
            label3.TabIndex = 13;
            label3.Text = "LISTAR CANDIDATOS POR VAGA";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateGray;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // dtgListaCandidatosVaga
            // 
            dtgListaCandidatosVaga.BackgroundColor = Color.Azure;
            dtgListaCandidatosVaga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaCandidatosVaga.Location = new Point(12, 74);
            dtgListaCandidatosVaga.Name = "dtgListaCandidatosVaga";
            dtgListaCandidatosVaga.RowTemplate.Height = 25;
            dtgListaCandidatosVaga.Size = new Size(776, 364);
            dtgListaCandidatosVaga.TabIndex = 14;
            dtgListaCandidatosVaga.CellDoubleClick += dtgListaCandidatosVaga_CellDoubleClick;
            dtgListaCandidatosVaga.CellFormatting += dtgListaCandidatosVaga_CellFormatting;
            // 
            // lbquantidade
            // 
            lbquantidade.AutoSize = true;
            lbquantidade.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbquantidade.ForeColor = Color.Red;
            lbquantidade.Location = new Point(713, 447);
            lbquantidade.Name = "lbquantidade";
            lbquantidade.Size = new Size(15, 19);
            lbquantidade.TabIndex = 18;
            lbquantidade.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(660, 447);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 17;
            label1.Text = "TOTAL:";
            // 
            // Frm_ListarCandidatosPorVaga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(lbquantidade);
            Controls.Add(label1);
            Controls.Add(dtgListaCandidatosVaga);
            Controls.Add(label3);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "Frm_ListarCandidatosPorVaga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LISTAR CANDIDATOS POR VAGA";
            Load += Frm_ListarCandidatosPorVaga_Load;
            ((System.ComponentModel.ISupportInitialize)dtgListaCandidatosVaga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private MenuStrip menuStrip1;
        private DataGridView dtgListaCandidatosVaga;
        private Label lbquantidade;
        private Label label1;
    }
}