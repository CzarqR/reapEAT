using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reapEAT 
{
    class IngredientSimple : IComparable
    {
        public int IdFood;
        public double Quantity;
        public DateTime ExpirationDate;
        public string Name;

        public IngredientSimple()
        {

        }

        public IngredientSimple(int IdFood, double Quantity, DateTime ExpirationDate, string name)
        {
            this.IdFood = IdFood;
            this.Quantity = Quantity;
            this.ExpirationDate = ExpirationDate;
            this.Name = name;
        }

        public int CompareTo(object obj)
        {
            IngredientSimple ingredient = (IngredientSimple)obj;
            if (ExpirationDate < ingredient.ExpirationDate)
                return -1;
            else if (ExpirationDate == ingredient.ExpirationDate)
                return 0;
            else
                return 1;
        }
    }
}
