namespace ClientApiJobs.Forms.Menu
{
    partial class Frm_MenuPrincipal
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
            menuStrip1 = new MenuStrip();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            vagasAbertasToolStripMenuItem = new ToolStripMenuItem();
            minhasVagasToolStripMenuItem = new ToolStripMenuItem();
            vagasQToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            lb_userlogado = new Label();
            btnCadastraVaga = new Button();
            lbPerfil = new Label();
            label4 = new Label();
            btnAreaCandidato = new Button();
            btnListaCandidatoVaga = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateGray;
            menuStrip1.Items.AddRange(new ToolStripItem[] { relatórioToolStripMenuItem, minhasVagasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(672, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vagasAbertasToolStripMenuItem });
            relatórioToolStripMenuItem.ForeColor = Color.Silver;
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(66, 20);
            relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // vagasAbertasToolStripMenuItem
            // 
            vagasAbertasToolStripMenuItem.Name = "vagasAbertasToolStripMenuItem";
            vagasAbertasToolStripMenuItem.Size = new Size(147, 22);
            vagasAbertasToolStripMenuItem.Text = "Vagas Abertas";
            vagasAbertasToolStripMenuItem.Click += vagasAbertasToolStripMenuItem_Click;
            // 
            // minhasVagasToolStripMenuItem
            // 
            minhasVagasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vagasQToolStripMenuItem });
            minhasVagasToolStripMenuItem.ForeColor = Color.Silver;
            minhasVagasToolStripMenuItem.Name = "minhasVagasToolStripMenuItem";
            minhasVagasToolStripMenuItem.Size = new Size(91, 20);
            minhasVagasToolStripMenuItem.Text = "Minhas Vagas";
            // 
            // vagasQToolStripMenuItem
            // 
            vagasQToolStripMenuItem.Name = "vagasQToolStripMenuItem";
            vagasQToolStripMenuItem.Size = new Size(205, 22);
            vagasQToolStripMenuItem.Text = "Vagas que me candidatei";
            vagasQToolStripMenuItem.Click += vagasQToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(406, 311);
            label1.Name = "label1";
            label1.Size = new Size(98, 12);
            label1.TabIndex = 1;
            label1.Text = "USUÁRIO LOGADO:";
            // 
            // lb_userlogado
            // 
            lb_userlogado.AutoSize = true;
            lb_userlogado.BackColor = Color.White;
            lb_userlogado.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_userlogado.ForeColor = Color.Gainsboro;
            lb_userlogado.Location = new Point(504, 309);
            lb_userlogado.Name = "lb_userlogado";
            lb_userlogado.Size = new Size(11, 13);
            lb_userlogado.TabIndex = 2;
            lb_userlogado.Text = "-";
            // 
            // btnCadastraVaga
            // 
            btnCadastraVaga.ForeColor = Color.IndianRed;
            btnCadastraVaga.Location = new Point(12, 50);
            btnCadastraVaga.Name = "btnCadastraVaga";
            btnCadastraVaga.Size = new Size(140, 78);
            btnCadastraVaga.TabIndex = 3;
            btnCadastraVaga.Text = "CADASTRO DE VAGA";
            btnCadastraVaga.UseVisualStyleBackColor = true;
            btnCadastraVaga.Click += button1_Click;
            // 
            // lbPerfil
            // 
            lbPerfil.AutoSize = true;
            lbPerfil.BackColor = Color.White;
            lbPerfil.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbPerfil.ForeColor = Color.LightPink;
            lbPerfil.Location = new Point(504, 326);
            lbPerfil.Name = "lbPerfil";
            lbPerfil.Size = new Size(11, 13);
            lbPerfil.TabIndex = 6;
            lbPerfil.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(465, 328);
            label4.Name = "label4";
            label4.Size = new Size(39, 12);
            label4.TabIndex = 5;
            label4.Text = "PERFIL:";
            // 
            // btnAreaCandidato
            // 
            btnAreaCandidato.ForeColor = SystemColors.ActiveCaption;
            btnAreaCandidato.Location = new Point(171, 50);
            btnAreaCandidato.Name = "btnAreaCandidato";
            btnAreaCandidato.Size = new Size(149, 78);
            btnAreaCandidato.TabIndex = 7;
            btnAreaCandidato.Text = "AREA CANDIDATO";
            btnAreaCandidato.UseVisualStyleBackColor = true;
            btnAreaCandidato.Click += button1_Click_1;
            // 
            // btnListaCandidatoVaga
            // 
            btnListaCandidatoVaga.ForeColor = Color.OrangeRed;
            btnListaCandidatoVaga.Location = new Point(340, 50);
            btnListaCandidatoVaga.Name = "btnListaCandidatoVaga";
            btnListaCandidatoVaga.Size = new Size(206, 78);
            btnListaCandidatoVaga.TabIndex = 8;
            btnListaCandidatoVaga.Text = "LISTAR CANDIDATOS POR VAGA";
            btnListaCandidatoVaga.UseVisualStyleBackColor = true;
            btnListaCandidatoVaga.Click += button1_Click_2;
            // 
            // Frm_MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(672, 345);
            Controls.Add(btnListaCandidatoVaga);
            Controls.Add(btnAreaCandidato);
            Controls.Add(lbPerfil);
            Controls.Add(label4);
            Controls.Add(btnCadastraVaga);
            Controls.Add(lb_userlogado);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Frm_MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU PRINCIPAL";
            Load += Frm_MenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label label1;
        private Label lb_userlogado;
        private Button btnCadastraVaga;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem vagasAbertasToolStripMenuItem;
        private Label lbPerfil;
        private Label label4;
        private Button btnAreaCandidato;
        private ToolStripMenuItem minhasVagasToolStripMenuItem;
        private ToolStripMenuItem vagasQToolStripMenuItem;
        private Button btnListaCandidatoVaga;
    }
}