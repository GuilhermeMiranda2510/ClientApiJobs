﻿namespace ClientApiJobs.Forms.Empresa
{
    partial class Frm_EncerraVaga
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
            btnSalvar = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            txtDescricao = new TextBox();
            label4 = new Label();
            txtEmpresa = new TextBox();
            label2 = new Label();
            txtSalario = new TextBox();
            label1 = new Label();
            txtTituloVaga = new TextBox();
            label3 = new Label();
            lb_aberturavaga = new Label();
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Red;
            btnSalvar.Location = new Point(196, 231);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(187, 32);
            btnSalvar.TabIndex = 20;
            btnSalvar.Text = "ENCERRAR VAGA";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmpresa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSalario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTituloVaga);
            groupBox1.Location = new Point(4, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 160);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 106);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 7;
            label5.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Enabled = false;
            txtDescricao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescricao.Location = new Point(116, 86);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(438, 55);
            txtDescricao.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 55);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 5;
            label4.Text = "Empresa:";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Enabled = false;
            txtEmpresa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmpresa.Location = new Point(116, 54);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(218, 23);
            txtEmpresa.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(342, 53);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 3;
            label2.Text = "Salário:";
            // 
            // txtSalario
            // 
            txtSalario.Enabled = false;
            txtSalario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSalario.Location = new Point(406, 52);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(147, 23);
            txtSalario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 15);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 1;
            label1.Text = "Titulo da Vaga:";
            // 
            // txtTituloVaga
            // 
            txtTituloVaga.Enabled = false;
            txtTituloVaga.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTituloVaga.Location = new Point(116, 15);
            txtTituloVaga.Name = "txtTituloVaga";
            txtTituloVaga.Size = new Size(437, 23);
            txtTituloVaga.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(182, 28);
            label3.Name = "label3";
            label3.Size = new Size(221, 37);
            label3.TabIndex = 21;
            label3.Text = "ENCERRAR VAGA";
            // 
            // lb_aberturavaga
            // 
            lb_aberturavaga.AutoSize = true;
            lb_aberturavaga.BackColor = Color.DarkSlateGray;
            lb_aberturavaga.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_aberturavaga.ForeColor = Color.Red;
            lb_aberturavaga.Location = new Point(430, 2);
            lb_aberturavaga.Name = "lb_aberturavaga";
            lb_aberturavaga.Size = new Size(15, 19);
            lb_aberturavaga.TabIndex = 24;
            lb_aberturavaga.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkSlateGray;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(299, 3);
            label6.Name = "label6";
            label6.Size = new Size(127, 19);
            label6.TabIndex = 23;
            label6.Text = "Data de abertura:";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateGray;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(569, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // Frm_EncerraVaga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(569, 268);
            Controls.Add(lb_aberturavaga);
            Controls.Add(label6);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "Frm_EncerraVaga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ENCERRAR VAGA";
            Load += Frm_EncerraVaga_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalvar;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtDescricao;
        private Label label4;
        private TextBox txtEmpresa;
        private Label label2;
        private TextBox txtSalario;
        private Label label1;
        private TextBox txtTituloVaga;
        private Label label3;
        private Label lb_aberturavaga;
        private Label label6;
        private MenuStrip menuStrip1;
    }
}