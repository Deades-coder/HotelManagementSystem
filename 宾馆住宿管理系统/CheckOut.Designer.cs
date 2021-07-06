
namespace 宾馆住宿管理系统
{
    partial class CheckOut
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
            this.RoomNum = new System.Windows.Forms.ComboBox();
            this.CusName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sure = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RoomNum
            // 
            this.RoomNum.FormattingEnabled = true;
            this.RoomNum.Items.AddRange(new object[] {
            "101",
            "202",
            "303",
            "404",
            "505"});
            this.RoomNum.Location = new System.Drawing.Point(360, 120);
            this.RoomNum.Name = "RoomNum";
            this.RoomNum.Size = new System.Drawing.Size(127, 20);
            this.RoomNum.TabIndex = 12;
            // 
            // CusName
            // 
            this.CusName.Location = new System.Drawing.Point(66, 120);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(126, 21);
            this.CusName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(356, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "房间号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(62, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "顾客姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(62, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "请输入：";
            // 
            // Sure
            // 
            this.Sure.Location = new System.Drawing.Point(401, 262);
            this.Sure.Name = "Sure";
            this.Sure.Size = new System.Drawing.Size(86, 29);
            this.Sure.TabIndex = 13;
            this.Sure.Text = "确定";
            this.Sure.UseVisualStyleBackColor = true;
            this.Sure.Click += new System.EventHandler(this.Sure_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Location = new System.Drawing.Point(21, 19);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(29, 12);
            this.back.TabIndex = 14;
            this.back.Text = "返回";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Sure);
            this.Controls.Add(this.RoomNum);
            this.Controls.Add(this.CusName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CheckOut";
            this.Text = "退房";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RoomNum;
        private System.Windows.Forms.TextBox CusName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sure;
        private System.Windows.Forms.Label back;
    }
}