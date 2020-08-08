namespace StudentMag
{
    partial class ReUserName
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsedName = new System.Windows.Forms.TextBox();
            this.btBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(411, 272);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(353, 28);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入修改后的用户名：";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(255, 397);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(150, 49);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "确定";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "请输入现在的用户名：";
            // 
            // tbUsedName
            // 
            this.tbUsedName.Location = new System.Drawing.Point(411, 176);
            this.tbUsedName.Name = "tbUsedName";
            this.tbUsedName.Size = new System.Drawing.Size(353, 28);
            this.tbUsedName.TabIndex = 4;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(531, 397);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(150, 49);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "返回";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // ReUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentMag.Properties.Resources._5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 640);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.tbUsedName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Name = "ReUserName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改用户名";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsedName;
        private System.Windows.Forms.Button btBack;
    }
}