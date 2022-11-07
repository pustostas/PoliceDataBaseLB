using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceDataBaseLB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeplatformDataSet.criminal_in_act". При необходимости она может быть перемещена или удалена.
            this.criminal_in_actTableAdapter.Fill(this.policeplatformDataSet.criminal_in_act);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeplatformDataSet.act". При необходимости она может быть перемещена или удалена.
            this.actTableAdapter.Fill(this.policeplatformDataSet.act);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeplatformDataSet.criminal". При необходимости она может быть перемещена или удалена.
            this.criminalTableAdapter.Fill(this.policeplatformDataSet.criminal);
            dataGridView1.AutoGenerateColumns = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            actTableAdapter.Update(policeplatformDataSet);
            criminalTableAdapter.Update(policeplatformDataSet);
            criminal_in_actTableAdapter.Update(policeplatformDataSet);
        }

        private void criminalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = criminalBindingSource;
            dataGridView1.DataSource = criminalBindingSource;
            label1.Text = "Criminals";
        }

        private void actsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = actBindingSource;
            dataGridView1.DataSource = actBindingSource;
            label1.Text = "Acts";
        }

        private void criminalsInActsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = criminalinactBindingSource;
            dataGridView1.DataSource = criminalinactBindingSource;
            label1.Text = "Crimnals to acts";
        }
    }
}
