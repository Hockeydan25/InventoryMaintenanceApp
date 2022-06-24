using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace InventoryMaintenance
{
    public class InvItem    //added InvItem class, FTI default is private, Made public and program much happier.
    {
        /// <summary>
        /// <constructor no parameters.></constructor>
        /// </summary>
        public InvItem () { }             // constructor no parameters.

        public InvItem(int itemNo, string description, decimal price) =>
            (this.ItemNo, this.Description, this.Price) = (itemNo, description, price);
        /// <summary>
        /// 
        /// </summary>       
        public int ItemNo { get; set; }              //properties for the three. 

        public string Description { get; set; }   //InvItem constructor with three parameters. 

        public decimal Price { get; set; }

        public virtual string GetDisplayText()   // method to give a string to dispaly when added.
        {
            return ItemNo + ":  " + Description + ", "+ Price.ToString("c");
        }
    }
}
