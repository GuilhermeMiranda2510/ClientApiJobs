namespace ClientApiJobs.Forms.Empresa
{
    partial class Frm_RegistraNovaVaga
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
            menuStrip1 = new MenuStrip();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            txtDescricao = new TextBox();
            label4 = new Label();
            txtEmpresa = new TextBox();
            label2 = new Label();
            txtSalario = new TextBox();
            label1 = new Label();
            txtTituloVaga = new TextBox();
            btnSalvar = new Button();
            btnLimpar = new Button();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateGray;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(585, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(167, 34);
            label3.Name = "label3";
            label3.Size = new Size(264, 37);
            label3.TabIndex = 10;
            label3.Text = "CADASTRO DE VAGA";
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
            groupBox1.Location = new Point(12, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 166);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 111);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 7;
            label5.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(116, 91);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(428, 55);
            txtDescricao.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(294, 54);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 5;
            label4.Text = "Empresa:";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(369, 53);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(175, 23);
            txtEmpresa.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 55);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 3;
            label2.Text = "Salário:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(116, 53);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(166, 23);
            txtSalario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 1;
            label1.Text = "Titulo da Vaga:";
            // 
            // txtTituloVaga
            // 
            txtTituloVaga.Location = new Point(116, 20);
            txtTituloVaga.Name = "txtTituloVaga";
            txtTituloVaga.Size = new Size(428, 23);
            txtTituloVaga.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.DarkSlateGray;
            btnSalvar.Location = new Point(306, 246);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(128, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.ForeColor = Color.DarkSlateGray;
            btnLimpar.Location = new Point(172, 246);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(128, 23);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // Frm_RegistraNovaVaga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(585, 280);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "Frm_RegistraNovaVaga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRAR NOVA VAGA";
            Load += Frm_RegistraNovaVaga_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label label3;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtTituloVaga;
        private Label label2;
        private TextBox txtSalario;
        private Label label5;
        private TextBox txtDescricao;
        private Label label4;
        private TextBox txtEmpresa;
        private Button btnSalvar;
        private Button btnLimpar;
        private ToolTip toolTip1;
    }
}