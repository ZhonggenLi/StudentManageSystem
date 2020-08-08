using MySql.Data.MySqlClient;
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
    public partial class StuBasMag : Form
    {
        MySqlConnection sqlconn;
        MySqlDataAdapter adapter;
        DataSet myds;
        MySqlCommandBuilder cb; //用于自动生成针对单个表更新的SQL语句
        public static string conn = "Database=student;Data Source=127.0.0.1;User Id = root; Password = li20010309; pooling = false; CharSet = utf8; port = 3306";
        public StuBasMag()
        {
            InitializeComponent();
        }

        private void StuBasMag_Load(object sender, EventArgs e)
        {
            
            string query = "select * from bsdata";
            sqlconn = new MySqlConnection(conn);
            sqlconn.Open();

            adapter = new MySqlDataAdapter(new MySqlCommand(query, sqlconn));
            cb=new MySqlCommandBuilder(adapter);

            myds = new DataSet();

            adapter.Fill(myds, "bsdata");
            bindingSource1.DataSource = myds.Tables["bsdata"];
            dGVStuBas.DataSource = bindingSource1;
            dGVStuBas.Columns[0].HeaderText = "编号";
            dGVStuBas.Columns[1].HeaderText = "姓名";
            dGVStuBas.Columns[2].HeaderText = "生日";
            dGVStuBas.Columns[1].HeaderText = "电话";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(myds, "bsdata");
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK);
            }
            catch(DataException ee)
            {
                MessageBox.Show( ee.Message, "保存失败", MessageBoxButtons.OK);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            sqlconn.Close();
            Close();
        }

        private void dGVStuBas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show( e.Exception.Message, "保存失败", MessageBoxButtons.OK);
        }
    }
}
