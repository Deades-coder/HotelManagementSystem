
namespace 宾馆住宿管理系统
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txUserName = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.LoginSystem = new System.Windows.Forms.Button();
            this.SignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 13F);
            this.label3.Location = new System.Drawing.Point(48, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "欢迎使用宾馆住宿管理系统";
            // 
            // txUserName
            // 
            this.txUserName.Location = new System.Drawing.Point(120, 113);
            this.txUserName.Name = "txUserName";
            this.txUserName.Size = new System.Drawing.Size(209, 25);
            this.txUserName.TabIndex = 3;
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(120, 159);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(209, 25);
            this.txPassword.TabIndex = 4;
            // 
            // LoginSystem
            // 
            this.LoginSystem.Location = new System.Drawing.Point(74, 238);
            this.LoginSystem.Name = "LoginSystem";
            this.LoginSystem.Size = new System.Drawing.Size(75, 33);
            this.LoginSystem.TabIndex = 5;
            this.LoginSystem.Text = "登录";
            this.LoginSystem.UseVisualStyleBackColor = true;
            this.LoginSystem.Click += new System.EventHandler(this.LoginSystem_Click);
            // 
            // SignIn
            // 
            this.SignIn.Location = new System.Drawing.Point(227, 238);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(75, 33);
            this.SignIn.TabIndex = 6;
            this.SignIn.Text = "注册";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.LoginSystem);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.txUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txUserName;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.Button LoginSystem;
        private System.Windows.Forms.Button SignIn;
    }
}