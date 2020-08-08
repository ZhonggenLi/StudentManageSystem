namespace StudentMag
{
    partial class StudentMag
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMag));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生基本信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddBasic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearBasic = new System.Windows.Forms.ToolStripMenuItem();
            this.学生成绩信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddScore = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearScore = new System.Windows.Forms.ToolStripMenuItem();
            this.统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaAll = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRevName = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRevPass = new System.Windows.Forms.ToolStripMenuItem();
            this.userOperate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWithdrow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWithdSys = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生基本信息管理ToolStripMenuItem,
            this.学生成绩信息管理ToolStripMenuItem,
            this.统计ToolStripMenuItem,
            this.系统设置ToolStripMenuItem,
            this.userOperate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1303, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生基本信息管理ToolStripMenuItem
            // 
            this.学生基本信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddBasic,
            this.menuSearBasic});
            this.学生基本信息管理ToolStripMenuItem.Name = "学生基本信息管理ToolStripMenuItem";
            this.学生基本信息管理ToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.学生基本信息管理ToolStripMenuItem.Text = "学生基本信息管理";
            // 
            // menuAddBasic
            // 
            this.menuAddBasic.Enabled = false;
            this.menuAddBasic.Name = "menuAddBasic";
            this.menuAddBasic.Size = new System.Drawing.Size(342, 34);
            this.menuAddBasic.Text = "添加/删除/修改学生基本信息";
            this.menuAddBasic.Click += new System.EventHandler(this.menuAddBasic_Click);
            // 
            // menuSearBasic
            // 
            this.menuSearBasic.Enabled = false;
            this.menuSearBasic.Name = "menuSearBasic";
            this.menuSearBasic.Size = new System.Drawing.Size(342, 34);
            this.menuSearBasic.Text = "查询/修改学生基本信息";
            this.menuSearBasic.Click += new System.EventHandler(this.menuSearBasic_Click);
            // 
            // 学生成绩信息管理ToolStripMenuItem
            // 
            this.学生成绩信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddScore,
            this.menuSearScore});
            this.学生成绩信息管理ToolStripMenuItem.Name = "学生成绩信息管理ToolStripMenuItem";
            this.学生成绩信息管理ToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.学生成绩信息管理ToolStripMenuItem.Text = "学生成绩信息管理";
            // 
            // menuAddScore
            // 
            this.menuAddScore.Enabled = false;
            this.menuAddScore.Name = "menuAddScore";
            this.menuAddScore.Size = new System.Drawing.Size(342, 34);
            this.menuAddScore.Text = "添加/删除/修改学生成绩信息";
            this.menuAddScore.Click += new System.EventHandler(this.menuAddScore_Click);
            // 
            // menuSearScore
            // 
            this.menuSearScore.Enabled = false;
            this.menuSearScore.Name = "menuSearScore";
            this.menuSearScore.Size = new System.Drawing.Size(342, 34);
            this.menuSearScore.Text = "查询/修改学生成绩信息";
            this.menuSearScore.Click += new System.EventHandler(this.menuSearScore_Click);
            // 
            // 统计ToolStripMenuItem
            // 
            this.统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStaAll});
            this.统计ToolStripMenuItem.Name = "统计ToolStripMenuItem";
            this.统计ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.统计ToolStripMenuItem.Text = "统计";
            // 
            // menuStaAll
            // 
            this.menuStaAll.Enabled = false;
            this.menuStaAll.Name = "menuStaAll";
            this.menuStaAll.Size = new System.Drawing.Size(290, 34);
            this.menuStaAll.Text = "统计并输出成绩及排名";
            this.menuStaAll.Click += new System.EventHandler(this.menuStaAll_Click);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRevName,
            this.menuRevPass});
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // menuRevName
            // 
            this.menuRevName.Enabled = false;
            this.menuRevName.Name = "menuRevName";
            this.menuRevName.Size = new System.Drawing.Size(218, 34);
            this.menuRevName.Text = "修改用户名";
            this.menuRevName.Click += new System.EventHandler(this.menuRevName_Click);
            // 
            // menuRevPass
            // 
            this.menuRevPass.Enabled = false;
            this.menuRevPass.Name = "menuRevPass";
            this.menuRevPass.Size = new System.Drawing.Size(218, 34);
            this.menuRevPass.Text = "修改用户密码";
            this.menuRevPass.Click += new System.EventHandler(this.menuRevPass_Click);
            // 
            // userOperate
            // 
            this.userOperate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuLogon,
            this.menuWithdrow,
            this.menuWithdSys});
            this.userOperate.Name = "userOperate";
            this.userOperate.Size = new System.Drawing.Size(98, 28);
            this.userOperate.Text = "用户操作";
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(182, 34);
            this.menuLogin.Text = "登录";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuLogon
            // 
            this.menuLogon.Name = "menuLogon";
            this.menuLogon.Size = new System.Drawing.Size(182, 34);
            this.menuLogon.Text = "注册";
            this.menuLogon.Click += new System.EventHandler(this.menuLogon_Click);
            // 
            // menuWithdrow
            // 
            this.menuWithdrow.Enabled = false;
            this.menuWithdrow.Name = "menuWithdrow";
            this.menuWithdrow.Size = new System.Drawing.Size(182, 34);
            this.menuWithdrow.Text = "退出登录";
            this.menuWithdrow.Click += new System.EventHandler(this.menuWithdrow_Click);
            // 
            // menuWithdSys
            // 
            this.menuWithdSys.Name = "menuWithdSys";
            this.menuWithdSys.Size = new System.Drawing.Size(182, 34);
            this.menuWithdSys.Text = "退出系统";
            this.menuWithdSys.Click += new System.EventHandler(this.menuWithdSys_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华光综艺_CNKI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(512, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "请 先 登 录 !";
            // 
            // StudentMag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentMag.Properties.Resources.背景首页;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1303, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentMag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生管理系统";
            this.Load += new System.EventHandler(this.StudentMag_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生基本信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddBasic;
        private System.Windows.Forms.ToolStripMenuItem menuSearBasic;
        private System.Windows.Forms.ToolStripMenuItem 学生成绩信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddScore;
        private System.Windows.Forms.ToolStripMenuItem menuSearScore;
        private System.Windows.Forms.ToolStripMenuItem 统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStaAll;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRevName;
        private System.Windows.Forms.ToolStripMenuItem menuRevPass;
        private System.Windows.Forms.ToolStripMenuItem userOperate;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem menuLogon;
        private System.Windows.Forms.ToolStripMenuItem menuWithdrow;
        private System.Windows.Forms.ToolStripMenuItem menuWithdSys;
        private System.Windows.Forms.Label label1;
    }
}

