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

namespace MariaDbTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection connection_;
        string MyTable = "";
        private void OnCheckedChanged(object sender,EventArgs e)
        {
            DisplayCheckResults();
        }
        private void DisplayCheckResults()
        {
            
            if (rdbItem1.Checked)
                MyTable = Convert.ToString(rdbItem1.Text);
            if (rdbItem2.Checked)
                MyTable = Convert.ToString(rdbItem2.Text);
            
        }


        private void buttonOpenConnect_Click(object sender, EventArgs e)
        {
            string connectionStr = "server=Localhost;user id=root;password=666;database=test";
            //string connectionStr = "server=172.16.40.153;user id=root;password=123456;database=test";
            connection_ = new MySqlConnection(connectionStr);
            connection_.Open();
            MessageBox.Show("Connect OK!");
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (connection_ == null)
            {
                MessageBox.Show("Please open connect!");
                return;
            }

            string sql = string.Format("SELECT * FROM {0}", MyTable);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection_);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewMariaDB.DataSource = dataTable;
        }

        private void buttonCloseConnect_Click(object sender, EventArgs e)
        {
            if (connection_ != null)
            {
                connection_.Close();
                MessageBox.Show("Connect Close!");
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (connection_ == null)
            {
                MessageBox.Show("Please open connect!");
                return;
            }
            
            string sql = "";
            string username = "admin";
            string timestamp_name = DateTime.Now.ToString();
            string data = Convert.ToString(textBoxNO2.Text);
            
            if (MyTable == "chatdata")
                { sql = string.Format("INSERT INTO {0} (`username`,`data`) VALUES('{1}','{2}');", MyTable, username, data); }
            if (MyTable == "fobiddata")
                { sql = string.Format("INSERT INTO {0} (`data`) VALUES('{1}');", MyTable, data); }
            MySqlCommand command = new MySqlCommand(sql, connection_);
            int affectLines = command.ExecuteNonQuery();

            MessageBox.Show("Affect " + affectLines.ToString() + " line");

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (connection_ == null)
            {
                MessageBox.Show("Please open connect!");
                return;
            }
            int no = Convert.ToInt32(textBoxNO.Text);
           
            string sql = string.Format("DELETE FROM {0} WHERE id={1}", MyTable,no);
            MySqlCommand command = new MySqlCommand(sql, connection_);
            int affectLines = command.ExecuteNonQuery();

            MessageBox.Show("Affect " + affectLines.ToString() + " line");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
