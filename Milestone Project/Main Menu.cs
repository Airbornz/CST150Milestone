using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            invTable.RowCount++;
            invTable.Controls.Add(new Label() { Text = "Name"});
            invTable.Controls.Add(new Label() { Text = "SKU"});
            invTable.Controls.Add(new Label() { Text = "QTY"});
            invTable.Controls.Add(new Label() { Text = "Price"});
            invTable.Controls.Add(new Label() { Text = "Cost"});

            addRow("HDMI Cable", 1, 7, 7.99, 2.54);
            addRow("USB Cable", 2, 3, 5.99, 1.02);
            addRow("DVI Cable", 3, 8, 10.99, 7.89);
        }

        private void addRow(String name, int sku, int qty, double price, double cost)
        {
            invTable.RowCount++;
            invTable.Controls.Add(new Label() { Text = name });
            invTable.Controls.Add(new Label() { Text = sku.ToString() });
            invTable.Controls.Add(new Label() { Text = qty.ToString() });
            invTable.Controls.Add(new Label() { Text = "$" + price.ToString() });
            invTable.Controls.Add(new Label() { Text = "$" + cost.ToString() });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form form = new Add_Item();
            form.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form form = new Edit_Item();
            form.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Form form = new Remove_Item();
            form.Show();
        }
    }
}
