using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        // statement here that declares the list of items.
        private List<InvItem> invItems = null;


        private void frmInvMaint_Load(object sender, EventArgs e) //statement here that gets the list of items.
        {
            invItems = InvItemDB.GetItems();           
            FillItemListBox();                            //refreshes the list box.
        }

        private void FillItemListBox()// Add code here that loads the list box with the items in the list.
        {
            lstItems.Items.Clear();                               //clears out item list box.
            foreach (InvItem invItem in invItems)
            {
                lstItems.Items.Add(invItem.GetDisplayText());   //calls to method to dispaly items in class form.
            }
        }

        //method here that gets and returns a new item.
        private void btnAdd_Click(object sender, EventArgs e)  //  creates an instance of the New Item form.
        {
            frmNewItem newInvItemForm = new frmNewItem();
            InvItem invItem = newInvItemForm.GetNewItem();   // and then gets a new item from that form.
            if (invItem != null)
            {
                invItems.Add(invItem);                  //addition and then adds the item from the list.
                InvItemDB.SaveItems(invItems);              // saves the list of products.
                FillItemListBox();                          //refreshes the list box.
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;     //Setting up a message box user must deal with to delete an item from the list.
            if (i != -1)
            {
                InvItem invItem = invItems[i];
                string message = "Are you sure you want to delete "
                    + invItem.Description + "?";
                DialogResult button =
                    MessageBox.Show(message, "Click to confirm delete",
                    MessageBoxButtons.YesNo);
                if(button == DialogResult.Yes)          
                {
                    invItems.Remove(invItem);           //deletion and then removes the item from the list.
                    InvItemDB.SaveItems(invItems);          // saves the list of products.
                    FillItemListBox();                      //refreshes the list box.
                }                             
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e) // Standard close ends program.
        {
            this.Close();
        }
    }
}
