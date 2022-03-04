using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coolerAttractions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void attractionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attractionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database7DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database7DataSet1.Attractions' table. You can move, or remove it, as needed.
            this.attractionsTableAdapter1.Fill(this.database7DataSet1.Attractions);
            // TODO: This line of code loads data into the 'database7DataSet.Attractions' table. You can move, or remove it, as needed.
            this.attractionsTableAdapter.Fill(this.database7DataSet.Attractions);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // connection string  
            try
            {
                // Query database  
                var contactDetails =
                   from c in database7DataSet.Attractions
                   where c.Water == true
                   orderby c.Name
                   select c;
                attractionsDataGridView.DataSource = contactDetails.AsDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
