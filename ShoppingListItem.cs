using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reapEAT
{
    class ShoppingListItem
    {
        public double Quantity;
        public string Name;
        public int Id;

        public ShoppingListItem(double Quantity, string Name, int Id)
        {
            this.Name = Name;
            this.Quantity = Quantity;
            this.Id = Id;
        }
    }
}
