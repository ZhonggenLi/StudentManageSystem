using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMag
{
    public partial class StudentMag : Form
    {
        public StudentMag()
        {
            InitializeComponent();
        }

        private void StudentMag_Load(object sender, EventArgs e)
        {

        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                menuAddBasic.Enabled = true;
                menuSearBasic.Enabled = true;
                menuAddScore.Enabled = true;
                menuSearScore.Enabled = true;
                menuStaAll.Enabled = true;
                menuRevName.Enabled = true;
                menuRevPass.Enabled = true;
                menuWithdrow.Enabled = true;
                menuLogin.Enabled = false;
                menuLogon.Enabled = false;
                label1.Text = "";
            }
            else Close();
        }

        private void menuWithdrow_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("您确定退出当前帐号吗？", "提示", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                menuAddBasic.Enabled = false;
                menuSearBasic.Enabled = false;
                menuAddScore.Enabled = false;
                menuSearScore.Enabled = false;
                menuStaAll.Enabled = false;
                menuRevName.Enabled = false;
                menuRevPass.Enabled = false;
                menuWithdrow.Enabled = false;
                menuLogin.Enabled = true;
                menuLogon.Enabled = true;
                label1.Text = "请先登录";
            }

        }

        private void menuWithdSys_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("感谢使用本系统！", "您即将退出系统", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Close();
        }

        private void menuAddBasic_Click(object sender, EventArgs e)
        {
            StuBasMag stubasmag = new StuBasMag();
            stubasmag.Show();
        }

        private void menuSearBasic_Click(object sender, EventArgs e)
        {
            StuBasQue stuBasQue = new StuBasQue();
            stuBasQue.Show();
        }

        private void menuAddScore_Click(object sender, EventArgs e)
        {
            new StuScoMag().Show(); 
        }

        private void menuSearScore_Click(object sender, EventArgs e)
        {
            new StuScoQue().Show();
        }

        private void menuStaAll_Click(object sender, EventArgs e)
        {
            new StaScore().Show();
        }

        private void menuLogon_Click(object sender, EventArgs e)
        {
            Logon logon = new Logon();
            if (logon.ShowDialog() == DialogResult.OK) ;
            else logon.Close();

        }

        private void menuRevName_Click(object sender, EventArgs e)
        {
            ReUserName reusername= new ReUserName();
            if(reusername.ShowDialog()==DialogResult.Cancel)
            {
                reusername.Close();
            }
        }

        private void menuRevPass_Click(object sender, EventArgs e)
        {
           ReUserPass reuserpass= new ReUserPass();
            if (reuserpass.ShowDialog() == DialogResult.Cancel)
            {
                reuserpass.Close();
            }
        }
    }
}
