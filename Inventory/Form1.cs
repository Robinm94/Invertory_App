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
    public partial class InventoryForm : Form
    {
        //private List<InventoryItem> inventoryItems;
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to exit?", "Exit Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            Form form = new NewInventoryItemForm();
            form.ShowDialog();
            InventoryItem item = (form as NewInventoryItemForm).Item;
            if (item != null)
            {
                InventoryDB.SaveItems(InventoryDB.GetItems().Append(item).ToList()); 
                LoadItems();
            }

        }

        private void LoadItems()
        {
            lstItems.Items.Clear();
            foreach (InventoryItem item in InventoryDB.GetItems())
            {
                lstItems.Items.Add(item);
            }
        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedIndex != -1)
            {
                DialogResult d = MessageBox.Show("Do you want to delete this item?", "Delete Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    List<InventoryItem> inventoryItems = InventoryDB.GetItems();
                    inventoryItems.RemoveAt(lstItems.SelectedIndex);
                    InventoryDB.SaveItems(inventoryItems);
                    LoadItems();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
