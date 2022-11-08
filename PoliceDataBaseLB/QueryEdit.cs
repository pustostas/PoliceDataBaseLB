using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace PoliceDataBaseLB
{
    public partial class QueryEdit : Form
    {
        const string ConnectionString = @"Dsn=MySQL Data Source;uid=root;server=127.0.0.1;database=policeplatform;port=3306;";
        public QueryEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection sqlconn = new OdbcConnection(ConnectionString);
                sqlconn.Open();
                OdbcDataAdapter oda = new OdbcDataAdapter(TestInput.Text, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestInput.Clear();
            TestInput.Text = "Select";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
