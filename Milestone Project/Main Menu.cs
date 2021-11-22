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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            invTable.RowCount++;
            invTable.Controls.Add(new Label() { Text = "Name"});
            invTable.Controls.Add(new Label() { Text = "SKU"});
            invTable.Controls.Add(new Label() { Text = "QTY"});
            invTable.Controls.Add(new Label() { Text = "Price"});
            invTable.Controls.Add(new Label() { Text = "Cost"});

            InventoryItem item1 = new InventoryItem("Apple", 036000291452, 2141543, 2, 1, .5);
            InventoryItem item2 = new InventoryItem("Orange", 036000291453, 2141543, 2, 1, .5);
            addRow(item1);
            addRow(item2);
        }

        private void addRow(InventoryItem item)
        {
            invTable.RowCount++;
            invTable.Controls.Add(new Label() { Text = item.getName() });
            invTable.Controls.Add(new Label() { Text = item.getSKU().ToString() });
            invTable.Controls.Add(new Label() { Text = item.getQuantity().ToString() });
            invTable.Controls.Add(new Label() { Text = "$" + item.getPrice().ToString() });
            invTable.Controls.Add(new Label() { Text = "$" + item.getCost().ToString() });
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

        private void formMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
