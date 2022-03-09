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

        private void waterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (waterCheck.Checked == false)
            {
                attractionsDataGridView.DataSource = attractionsBindingSource;
            }
            else
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

        private void scaryCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (scaryCheck.Checked == false)
            {
                attractionsDataGridView.DataSource = attractionsBindingSource;
            }
            else
            {
                // connection string  
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in database7DataSet.Attractions
                       where c.Category_2 == "Scary"
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

        private void trainCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (trainCheck.Checked == false)
            {
                attractionsDataGridView.DataSource = attractionsBindingSource;
            }
            else
            {
                // connection string  
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in database7DataSet.Attractions
                       where c.Category_2 == "Train"
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

        private void spinCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (spinCheck.Checked == false)
            {
                attractionsDataGridView.DataSource = attractionsBindingSource;
            }
            else
            {
                // connection string  
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in database7DataSet.Attractions
                       where c.Category_1 == "Spin"
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

        private void loudCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (loudCheck.Checked == false)
            {
                attractionsDataGridView.DataSource = attractionsBindingSource;
            }
            else
            {
                // connection string  
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in database7DataSet.Attractions
                       where c.Category_1 == "Loud"
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

        private void kidsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (kidsCheck.Checked == false)
            {
                attractionsDataGridView.DataSource = attractionsBindingSource;
            }
            else
            {
                // connection string  
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in database7DataSet.Attractions
                       where c.Category_1 == "Kids"
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

        private void boatCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (boatCheck.Checked == false)
            {
                attractionsDataGridView.DataSource = attractionsBindingSource;
            }
            else
            {
                // connection string  
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in database7DataSet.Attractions
                       where c.Category_2 == "Boat"
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

        private void slowCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (slowCheck.Checked == false)
            {
                attractionsDataGridView.DataSource = attractionsBindingSource;
            }
            else
            {
                // connection string  
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in database7DataSet.Attractions
                       where c.Category_2 == "Slow"
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

        private void entertainCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (entertainCheck.Checked == false)
            {
                attractionsDataGridView.DataSource = attractionsBindingSource;
            }
            else
            {
                // connection string  
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in database7DataSet.Attractions
                       where c.Category_2 == "Entertainment"
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

        private void transportCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (transportCheck.Checked == false)
            {
                attractionsDataGridView.DataSource = attractionsBindingSource;
            }
            else
            {
                // connection string  
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in database7DataSet.Attractions
                       where c.Category_1 == "Transportation"
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

        private void thrilCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (thrilCheck.Checked == false)
            {
                attractionsDataGridView.DataSource = attractionsBindingSource;
            }
            else
            {
                // connection string  
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in database7DataSet.Attractions
                       where c.Category_2 == "Thrill"
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

        private void dropCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (dropCheck.Checked == false)
            {
                attractionsDataGridView.DataSource = attractionsBindingSource;
            }
            else
            {
                // connection string  
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in database7DataSet.Attractions
                       where c.Category_2 == "Drop"
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

        private void exploreCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (exploreCheck.Checked == false)
            {
                attractionsDataGridView.DataSource = attractionsBindingSource;
            }
            else
            {
                // connection string  
                try
                {
                    // Query database  
                    var contactDetails =
                       from c in database7DataSet.Attractions
                       where c.Category_2 == "Explore"
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
}
