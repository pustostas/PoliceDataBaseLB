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
    public partial class RSForm : Form
    {
        public RSForm()
        {
            InitializeComponent();
        }

        private void actBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.policeplatformDataSet);

        }

        private void RSForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policeplatformDataSet.criminal_in_act' table. You can move, or remove it, as needed.
            this.criminal_in_actTableAdapter.Fill(this.policeplatformDataSet.criminal_in_act);
            // TODO: This line of code loads data into the 'policeplatformDataSet.act' table. You can move, or remove it, as needed.
            this.actTableAdapter.Fill(this.policeplatformDataSet.act);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to accept changes?", "Changing data", MessageBoxButtons.YesNo) == DialogResult.Yes)
 {
                actBindingSource.EndEdit();
                actTableAdapter.Update(policeplatformDataSet);
                criminal_in_actTableAdapter.Update(policeplatformDataSet);
            }

        }
    }
}
