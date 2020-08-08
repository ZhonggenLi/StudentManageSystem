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
    public partial class StuBasQue : Form
    {
        MySqlConnection sqlconn;
        MySqlDataAdapter adapter;
        DataSet myds;
        MySqlCommandBuilder cb; //用于自动生成针对单个表更新的SQL语句
        public static string conn = "Database=student;Data Source=127.0.0.1;User Id = root; Password = li20010309; pooling = false; CharSet = utf8; port = 3306";
        public StuBasQue()
        {
            InitializeComponent();
        }

        private void StuBasQue_Load(object sender, EventArgs e)
        {
            //string query = "select * from bsdata";
            sqlconn = new MySqlConnection(conn);
            sqlconn.Open();

            //adapter = new MySqlDataAdapter(new MySqlCommand(query, sqlconn));
            //new MySqlCommandBuilder(adapter);

            //myds = new DataSet();

            //adapter.Fill(myds, "bsdata");
            //bindingSource1.DataSource = myds.Tables["bsdata"];
            //dataGridView1.DataSource = bindingSource1;
            //dataGridView1.Columns[0].HeaderText = "编号";
            //dataGridView1.Columns[1].HeaderText = "姓名";
            //dataGridView1.Columns[2].HeaderText = "生日";
            //dataGridView1.Columns[1].HeaderText = "电话";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(myds, "bsdata");
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK);
            }
            catch (DataException ee)
            {
                MessageBox.Show(ee.Message, "保存失败", MessageBoxButtons.OK);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            sqlconn.Close();
            Close();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "保存失败", MessageBoxButtons.OK);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQue_Click(object sender, EventArgs e)
        {
            string key = comKey.Text;
            string keyreal;
            if (key == "姓名")
                keyreal = "name";
            else
                keyreal = "gender";

            string query = "select * from bsdata where "+keyreal+" like '%"+tbName.Text.Trim()+"%'";

            adapter = new MySqlDataAdapter(new MySqlCommand(query, sqlconn));
            new MySqlCommandBuilder(adapter);

            myds = new DataSet();

            adapter.Fill(myds, "bsdata");
            bindingSource1.DataSource = myds.Tables["bsdata"];
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[0].HeaderText = "编号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "生日";
            dataGridView1.Columns[1].HeaderText = "电话";
        }
    }
}
