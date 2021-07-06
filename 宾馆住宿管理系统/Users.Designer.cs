
namespace 宾馆住宿管理系统
{
    partial class Users
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
            this.listView = new System.Windows.Forms.ListView();
            this.check = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.returnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(50, 94);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(700, 330);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(89, 26);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(108, 40);
            this.check.TabIndex = 2;
            this.check.Text = "查询/刷新";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(246, 26);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 40);
            this.add.TabIndex = 3;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(403, 26);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(108, 40);
            this.delete.TabIndex = 4;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // returnHome
            // 
            this.returnHome.Location = new System.Drawing.Point(561, 26);
            this.returnHome.Name = "returnHome";
            this.returnHome.Size = new System.Drawing.Size(108, 40);
            this.returnHome.TabIndex = 5;
            this.returnHome.Text = "返回主页面";
            this.returnHome.UseVisualStyleBackColor = true;
            this.returnHome.Click += new System.EventHandler(this.returnHome_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnHome);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.check);
            this.Controls.Add(this.listView);
            this.Name = "Users";
            this.Text = "用户";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button returnHome;
    }
}