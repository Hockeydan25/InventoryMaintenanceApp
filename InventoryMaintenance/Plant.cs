using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class Plant : InvItem //subclass PLant : base class InvItem

    {
        public Plant () {}      //empty constructor

        private string size;  

        public Plant(int itemNo, string desciption,
            decimal price, string size) : base(itemNo, desciption, price)
        {
            this.size = size;  //Intialized the Size field after the base cklass constructor called
        }

        public string Size { get; set; }  //inherits a new property

        public override string GetDisplayText() =>
            this.ItemNo + this.Description + this.Price.ToString("C") + "(" + this.Size + ")";
    }
}
