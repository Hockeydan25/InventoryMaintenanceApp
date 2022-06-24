using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class Supply : InvItem //subclass Supply : base class InvItem
    {
        public Supply() { }

        private string manufacturer;

        public Supply(int itemNo, string desciption,
            decimal price, string manufaturer) : base(itemNo, desciption, price)
        {
            this.Manufacturer = manufacturer;
        }

        public string Manufacturer { get; set; }

        public override string GetDisplayText() =>
            this.ItemNo +  this.Description + this.Price.ToString("C") + "(" + this.Manufacturer + ")";

    }
}
