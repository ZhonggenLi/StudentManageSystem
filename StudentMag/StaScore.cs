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
    public partial class StaScore : Form
    {
        MySqlConnection sqlconn;
        MySqlDataAdapter adapter;
        DataSet myds;
        MySqlCommandBuilder cb; //用于自动生成针对单个表更新的SQL语句
        public static string conn = "Database=student;Data Source=127.0.0.1;User Id = root; Password = li; pooling = false; CharSet = utf8; port = 3306";
        public StaScore()
        {
            InitializeComponent();
        }

        private void StaScore_Load(object sender, EventArgs e)
        {
            sqlconn = new MySqlConnection(conn);
            sqlconn.Open();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(this.dataGridView1.RowHeadersDefaultCellStyle.ForeColor);
            e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), this.dataGridView1.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
        }

        private void btScore_Click(object sender, EventArgs e)
        {
            string key = comboBox1.Text, query;
            string key1 = "mathscore", key2 = "physcore", key3 = "csscore", key4 = "allscore";
            int ikey1 = 0, ikey2 = 0, ikey3 = 0, ikey4 = 0;
            if (key == "数学单科排名")
            {
                ikey1 = 1;
                query = "select name," + key1 + " from score order by '" + key1 + "' desc";
            }
            else if (key == "物理单科排名")
            {
                ikey2 = 1;
                query = "select name," + key2 + " from score order by '" + key2 + "' desc";
            }
            else if (key == "计算机单科排名")
            {
                ikey3 = 1;
                query = "select name," + key3 + " from score order by '" + key3 + "' desc";
            }
            else
            {
                ikey4 = 1;
                query = "select name," + key4 + " from score order by '" + key4 + "' desc";
            }

            

            adapter = new MySqlDataAdapter(new MySqlCommand(query, sqlconn));
            new MySqlCommandBuilder(adapter);

            myds = new DataSet();

            adapter.Fill(myds, "score");
            bindingSource1.DataSource = myds.Tables["score"];
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[0].HeaderText = "姓名";
            if (ikey1 == 1)
            {
                dataGridView1.Columns[1].HeaderText = "数学单科成绩";
            }
            else if (ikey2 == 1)
            {
                dataGridView1.Columns[1].HeaderText = "物理单科成绩";
            }
            else if (ikey3 == 1)
            {
                dataGridView1.Columns[1].HeaderText = "计算机单科成绩";
            }
            else
            {
                dataGridView1.Columns[1].HeaderText = "总成绩";
            }
        }
    }
}
