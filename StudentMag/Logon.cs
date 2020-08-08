using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMag
{
    public partial class Logon : Form
    {
        public Logon()
        {
            InitializeComponent();
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Database=student;Data Source=127.0.0.1;User Id = root; Password = li; pooling = false; CharSet = utf8; port = 3306");
            if(tbName.Text==""||tbPassword.Text==""||tbPassword2.Text==""||tbPhone.Text=="")
            {
                MessageBox.Show("各项不能为空！", "提示", MessageBoxButtons.OK);
                return;
            }
            if(!string.Equals(tbPassword.Text,tbPassword2.Text))
            {
                MessageBox.Show("两次输入密码不一致！", "提示", MessageBoxButtons.OK);
                return;
            }
            try
            {
                connection.Open();
                String sql = "select name from adacount where name='" + tbName.Text + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("此用户名已被使用", "提示", MessageBoxButtons.OK);
                    return;
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
            try
            {
                connection.Open();
                string sqlcmd = "insert into adacount(name,password,phone) values ('"+tbName.Text+"','"+tbPassword.Text+"','"+tbPhone.Text+"')";
                MySqlCommand command2 = new MySqlCommand(sqlcmd, connection);
                command2.ExecuteNonQuery();
                if(command2.ExecuteNonQuery()!=0)
                {
                    MessageBox.Show("注册成功！", "提示", MessageBoxButtons.OK);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("注册失败！", "提示", MessageBoxButtons.OK);
                }
            }
            catch (SqlException ee)
            {
                Console.WriteLine(ee.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
