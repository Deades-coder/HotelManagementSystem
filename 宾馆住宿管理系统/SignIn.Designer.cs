
namespace 宾馆住宿管理系统
{
    partial class SignIn
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
            this.userName = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.txUserName = new System.Windows.Forms.TextBox();
            this.txpassword = new System.Windows.Forms.TextBox();
            this.getIntoSign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 13F);
            this.label1.Location = new System.Drawing.Point(132, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "注册界面";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(71, 123);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(67, 15);
            this.userName.TabIndex = 1;
            this.userName.Text = "用户名：";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(71, 168);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(52, 15);
            this.password.TabIndex = 2;
            this.password.Text = "密码：";
            // 
            // txUserName
            // 
            this.txUserName.Location = new System.Drawing.Point(145, 118);
            this.txUserName.Name = "txUserName";
            this.txUserName.Size = new System.Drawing.Size(170, 25);
            this.txUserName.TabIndex = 3;
            // 
            // txpassword
            // 
            this.txpassword.Location = new System.Drawing.Point(145, 163);
            this.txpassword.Name = "txpassword";
            this.txpassword.Size = new System.Drawing.Size(170, 25);
            this.txpassword.TabIndex = 4;
            // 
            // getIntoSign
            // 
            this.getIntoSign.Location = new System.Drawing.Point(144, 236);
            this.getIntoSign.Name = "getIntoSign";
            this.getIntoSign.Size = new System.Drawing.Size(75, 39);
            this.getIntoSign.TabIndex = 5;
            this.getIntoSign.Text = "注册";
            this.getIntoSign.UseVisualStyleBackColor = true;
            this.getIntoSign.Click += new System.EventHandler(this.getIntoSign_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.getIntoSign);
            this.Controls.Add(this.txpassword);
            this.Controls.Add(this.txUserName);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.Text = "用户注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txUserName;
        private System.Windows.Forms.TextBox txpassword;
        private System.Windows.Forms.Button getIntoSign;
    }
}