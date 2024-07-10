namespace ClientApiJobs.Forms.Login
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtEmail = new TextBox();
            label1 = new Label();
            btnAutenticar = new Button();
            txtSenha = new TextBox();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            groupBox1 = new GroupBox();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(53, 25);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 23);
            txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "E-mail:";
            // 
            // btnAutenticar
            // 
            btnAutenticar.FlatStyle = FlatStyle.Flat;
            btnAutenticar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAutenticar.ForeColor = Color.DarkSlateGray;
            btnAutenticar.Location = new Point(77, 106);
            btnAutenticar.Name = "btnAutenticar";
            btnAutenticar.Size = new Size(128, 23);
            btnAutenticar.TabIndex = 2;
            btnAutenticar.Text = "AUTENTICAR";
            btnAutenticar.UseVisualStyleBackColor = true;
            btnAutenticar.Click += button1_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(53, 68);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(224, 23);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 76);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 6;
            label2.Text = "Senha:";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateGray;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(309, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAutenticar);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Location = new Point(12, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 143);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 35);
            label3.Name = "label3";
            label3.Size = new Size(178, 37);
            label3.TabIndex = 9;
            label3.Text = "ClientAPIJobs";
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(309, 230);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label label1;
        private Button btnAutenticar;
        private TextBox txtSenha;
        private Label label2;
        private MenuStrip menuStrip1;
        private GroupBox groupBox1;
        private Label label3;
        private ToolTip toolTip1;
    }
}
