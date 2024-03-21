using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class NewInventoryItemForm : Form
    {
        public InventoryItem Item { get; set; }

        public NewInventoryItemForm()
        {
            InitializeComponent();
        }

        private void BtnSaveItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtItemNo.Text) || !Int32.TryParse(txtItemNo.Text, out Int32 itemNo))
            {
                MessageBox.Show("Invalid Item Number", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("Invalid Description", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Item = new InventoryItem()
            {
                ItemNo = itemNo,
                Description = txtDesc.Text,
                Price = numPrice.Value
            };
            this.Close();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Item = null;
            this.Close();
        }
    }
}
