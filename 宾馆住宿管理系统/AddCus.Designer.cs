
namespace 宾馆住宿管理系统
{
    partial class AddCus
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
            this.txCusName = new System.Windows.Forms.Label();
            this.txCusPhone = new System.Windows.Forms.Label();
            this.txRoomNum = new System.Windows.Forms.Label();
            this.tbCusName = new System.Windows.Forms.TextBox();
            this.tbCusPhone = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 13F);
            this.label1.Location = new System.Drawing.Point(84, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加顾客信息";
            // 
            // txCusName
            // 
            this.txCusName.AutoSize = true;
            this.txCusName.Location = new System.Drawing.Point(28, 82);
            this.txCusName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txCusName.Name = "txCusName";
            this.txCusName.Size = new System.Drawing.Size(65, 12);
            this.txCusName.TabIndex = 1;
            this.txCusName.Text = "顾客姓名：";
            // 
            // txCusPhone
            // 
            this.txCusPhone.AutoSize = true;
            this.txCusPhone.Location = new System.Drawing.Point(28, 121);
            this.txCusPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txCusPhone.Name = "txCusPhone";
            this.txCusPhone.Size = new System.Drawing.Size(77, 12);
            this.txCusPhone.TabIndex = 2;
            this.txCusPhone.Text = "顾客手机号：";
            // 
            // txRoomNum
            // 
            this.txRoomNum.AutoSize = true;
            this.txRoomNum.Location = new System.Drawing.Point(28, 158);
            this.txRoomNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txRoomNum.Name = "txRoomNum";
            this.txRoomNum.Size = new System.Drawing.Size(53, 12);
            this.txRoomNum.TabIndex = 3;
            this.txRoomNum.Text = "房间号：";
            // 
            // tbCusName
            // 
            this.tbCusName.Location = new System.Drawing.Point(116, 77);
            this.tbCusName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCusName.Name = "tbCusName";
            this.tbCusName.Size = new System.Drawing.Size(134, 21);
            this.tbCusName.TabIndex = 4;
            // 
            // tbCusPhone
            // 
            this.tbCusPhone.Location = new System.Drawing.Point(116, 116);
            this.tbCusPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCusPhone.Name = "tbCusPhone";
            this.tbCusPhone.Size = new System.Drawing.Size(134, 21);
            this.tbCusPhone.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "未入住",
            "101",
            "202",
            "303",
            "404",
            "505"});
            this.comboBox1.Location = new System.Drawing.Point(116, 153);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 20);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(46, 196);
            this.add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(56, 37);
            this.add.TabIndex = 7;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(168, 196);
            this.cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(56, 37);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 282);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbCusPhone);
            this.Controls.Add(this.tbCusName);
            this.Controls.Add(this.txRoomNum);
            this.Controls.Add(this.txCusPhone);
            this.Controls.Add(this.txCusName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddCus";
            this.Text = "添加顾客";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txCusName;
        private System.Windows.Forms.Label txCusPhone;
        private System.Windows.Forms.Label txRoomNum;
        private System.Windows.Forms.TextBox tbCusName;
        private System.Windows.Forms.TextBox tbCusPhone;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancel;
    }
}