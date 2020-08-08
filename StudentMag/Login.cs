using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace StudentMag
{
    public partial class Login : Form
    {
        int iCount = 3;
        int flag = 1;
        public Login()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Database=student;Data Source=127.0.0.1;User Id = root; Password = li; pooling = false; CharSet = utf8; port = 3306");
            try
            {
                connection.Open();
                String sql = "select password from adacount where name='" + tbName.Text + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    if(reader.GetString(0)==tbPassword.Text)
                    DialogResult = DialogResult.OK;
                    else
                    {
                        flag = 0;
                    }
                }
                else
                {
                    flag = 0;
                }
                if(flag==0)
                {
                    iCount--;
                    if (iCount > 0)
                        labTip.Text = "用户名或密码输入错误，请重新输入。（" + iCount.ToString() + "次后将自动退出程序）";
                    else
                    {
                        MessageBox.Show("机会已用尽！程序将退出。", "提示", MessageBoxButtons.OK);
                        DialogResult = DialogResult.Cancel;
                    }
                }
            }
            catch (MySqlException ee)
            {
                Console.WriteLine(ee.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            labTip.Text = "";
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否退出系统？", "提示", MessageBoxButtons.YesNo)==DialogResult.Yes)
            DialogResult = DialogResult.Cancel;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            labTip.Text = "";
        }
    }
}
