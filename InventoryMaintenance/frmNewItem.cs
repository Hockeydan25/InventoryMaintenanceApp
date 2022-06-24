using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {
        public frmNewItem()
        {
            InitializeComponent();
        }

        // declares the inventory item.
        private InvItem invItem = null;


        public InvItem GetNewItem()  //Adds new item. method here that gets and returns a new item.
        {
            this.ShowDialog();   //message for usrer to deal with and return a NewinvItem.
            return invItem;
        }
       
        //private void rdo_CheckedChanged(Object sender, EventArgs e)
        //{
        //    if (rdoPlant.Checked)
        //    {
        //        lblPlantOrSupply.Text = "Plant: ";
        //        txtPlantOrSupply.Tag = "Plant";
        //    }
        //    else
        //    {
        //        lblPlantOrSupply.Text = "Supply: ";
        //        txtPlantOrSupply.Tag = "Supply";
        //    }
        //}
        private void btnSave_Click(object sender, EventArgs e)
        {                // Starts with data validation, creates a new item, and closes the form.

            if (IsValidData())
            {
                if(rdoPlant.Checked)
                    invItem = new InvItem(Convert.ToInt32(txtItemNo.Text), txtDescription.Text,
                      //  txtPlantOrSupply.Text,
                        Convert.ToDecimal(txtPrice.Text));
                
                else
                    invItem = new InvItem(Convert.ToInt32(txtItemNo.Text), txtDescription.Text,
                     //   txtPlantOrSupply.Text,
                        Convert.ToDecimal(txtPrice.Text));
                this.Close();
            }
        }

        private bool IsValidData()    //uses validator class to run data validation
        {
            return Validator.IsPresent(txtItemNo) &&   
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();        //closing the form saving data
        }
    }
}
