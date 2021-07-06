
namespace 宾馆住宿管理系统
{
    partial class Room
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
            this.check = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.State = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.bDay1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bDay2 = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(490, 390);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(157, 32);
            this.check.TabIndex = 1;
            this.check.Text = "查询";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(55, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(702, 283);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "已预订",
            "未入住",
            "已入住"});
            this.comboBox1.Location = new System.Drawing.Point(249, 365);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "标准间",
            "电竞房",
            "豪华套间",
            "大床房"});
            this.comboBox2.Location = new System.Drawing.Point(70, 365);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(119, 20);
            this.comboBox2.TabIndex = 4;
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.State.Location = new System.Drawing.Point(245, 343);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(66, 19);
            this.State.TabIndex = 5;
            this.State.Text = "状态：";
            this.State.Click += new System.EventHandler(this.label1_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Type.Location = new System.Drawing.Point(66, 343);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(66, 19);
            this.Type.TabIndex = 6;
            this.Type.Text = "类型：";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("宋体", 14.25F);
            this.date.Location = new System.Drawing.Point(66, 408);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(104, 19);
            this.date.TabIndex = 7;
            this.date.Text = "起止日期：";
            // 
            // bDay1
            // 
            this.bDay1.FormattingEnabled = true;
            this.bDay1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.bDay1.Location = new System.Drawing.Point(177, 409);
            this.bDay1.Name = "bDay1";
            this.bDay1.Size = new System.Drawing.Size(62, 20);
            this.bDay1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(252, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "~";
            // 
            // bDay2
            // 
            this.bDay2.FormattingEnabled = true;
            this.bDay2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.bDay2.Location = new System.Drawing.Point(281, 408);
            this.bDay2.Name = "bDay2";
            this.bDay2.Size = new System.Drawing.Size(89, 20);
            this.bDay2.TabIndex = 10;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Location = new System.Drawing.Point(17, 17);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(29, 12);
            this.back.TabIndex = 11;
            this.back.Text = "返回";
            this.back.Click += new System.EventHandler(this.label2_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.bDay2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bDay1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.State);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.check);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.ComboBox bDay1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bDay2;
        private System.Windows.Forms.Label back;
    }
}