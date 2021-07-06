
namespace 宾馆住宿管理系统
{
    partial class Change
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
            this.txCusName = new System.Windows.Forms.TextBox();
            this.txCusPhone = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.changeDetail = new System.Windows.Forms.Button();
            this.deleteDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "顾客姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "顾客手机号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "房间号：";
            // 
            // txCusName
            // 
            this.txCusName.Location = new System.Drawing.Point(116, 34);
            this.txCusName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txCusName.Name = "txCusName";
            this.txCusName.Size = new System.Drawing.Size(138, 21);
            this.txCusName.TabIndex = 3;
            // 
            // txCusPhone
            // 
            this.txCusPhone.Location = new System.Drawing.Point(116, 64);
            this.txCusPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txCusPhone.Name = "txCusPhone";
            this.txCusPhone.Size = new System.Drawing.Size(138, 21);
            this.txCusPhone.TabIndex = 4;
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
            this.comboBox1.Location = new System.Drawing.Point(116, 94);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // changeDetail
            // 
            this.changeDetail.Location = new System.Drawing.Point(46, 156);
            this.changeDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changeDetail.Name = "changeDetail";
            this.changeDetail.Size = new System.Drawing.Size(56, 59);
            this.changeDetail.TabIndex = 6;
            this.changeDetail.Text = "修改";
            this.changeDetail.UseVisualStyleBackColor = true;
            this.changeDetail.Click += new System.EventHandler(this.changeDetail_Click);
            // 
            // deleteDetail
            // 
            this.deleteDetail.Location = new System.Drawing.Point(181, 156);
            this.deleteDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteDetail.Name = "deleteDetail";
            this.deleteDetail.Size = new System.Drawing.Size(56, 59);
            this.deleteDetail.TabIndex = 7;
            this.deleteDetail.Text = "删除";
            this.deleteDetail.UseVisualStyleBackColor = true;
            this.deleteDetail.Click += new System.EventHandler(this.deleteDetail_Click);
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 282);
            this.Controls.Add(this.deleteDetail);
            this.Controls.Add(this.changeDetail);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txCusPhone);
            this.Controls.Add(this.txCusName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Change";
            this.Text = "修改/删除";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txCusName;
        private System.Windows.Forms.TextBox txCusPhone;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button changeDetail;
        private System.Windows.Forms.Button deleteDetail;
    }
}