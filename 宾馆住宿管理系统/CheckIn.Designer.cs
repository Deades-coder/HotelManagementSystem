
namespace 宾馆住宿管理系统
{
    partial class CheckIn
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
            this.back = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EndDay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StartDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RoomNum = new System.Windows.Forms.ComboBox();
            this.CusName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Location = new System.Drawing.Point(19, 14);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(29, 12);
            this.back.TabIndex = 0;
            this.back.Text = "返回";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(53, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EndDay
            // 
            this.EndDay.Location = new System.Drawing.Point(439, 188);
            this.EndDay.Name = "EndDay";
            this.EndDay.Size = new System.Drawing.Size(114, 21);
            this.EndDay.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(436, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "结束日期";
            // 
            // StartDay
            // 
            this.StartDay.Location = new System.Drawing.Point(291, 188);
            this.StartDay.Name = "StartDay";
            this.StartDay.Size = new System.Drawing.Size(107, 21);
            this.StartDay.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(288, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "起始日期";
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
            this.RoomNum.Location = new System.Drawing.Point(351, 123);
            this.RoomNum.Name = "RoomNum";
            this.RoomNum.Size = new System.Drawing.Size(127, 20);
            this.RoomNum.TabIndex = 15;
            this.RoomNum.SelectedIndexChanged += new System.EventHandler(this.RoomNum_SelectedIndexChanged);
            // 
            // CusName
            // 
            this.CusName.Location = new System.Drawing.Point(57, 123);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(126, 21);
            this.CusName.TabIndex = 14;
            this.CusName.TextChanged += new System.EventHandler(this.CusName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(347, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "房间号：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(53, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "顾客姓名：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Sure
            // 
            this.Sure.Location = new System.Drawing.Point(467, 262);
            this.Sure.Name = "Sure";
            this.Sure.Size = new System.Drawing.Size(86, 29);
            this.Sure.TabIndex = 20;
            this.Sure.Text = "确定";
            this.Sure.UseVisualStyleBackColor = true;
            this.Sure.Click += new System.EventHandler(this.Sure_Click);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.Sure);
            this.Controls.Add(this.EndDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StartDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RoomNum);
            this.Controls.Add(this.CusName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CheckIn";
            this.Text = "入住";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EndDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StartDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox RoomNum;
        private System.Windows.Forms.TextBox CusName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sure;
    }
}