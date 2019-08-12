using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reapEAT
{
    class Ingredient : IComparable
    {
        public int IdFood;
        public string Name;
        public double Quantity;
        public int Calories;

        public Ingredient()
        {

        }

        public Ingredient(int IdFood, string Name, double Quantity, int Calories)
        {
            this.IdFood = IdFood;
            this.Quantity = Quantity;
            this.Name = Name;
            this.Calories = Calories;
        }

        public int CompareTo(object obj)
        {
            Ingredient ingredient = (Ingredient)obj;
            if (IdFood < ingredient.IdFood)
                return -1;
            else if (IdFood == ingredient.IdFood)
                return 0;
            else
                return 1;
        }
    }
}
