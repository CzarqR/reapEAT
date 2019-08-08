using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reapEAT
{
    class Program
    {


        static void Main()
        {
            //for (int i = 0; i < 10000; i++)
            //{
            //    StringCorrect.CheckIngredients(" 1 3 5 7 9 11 13 15 17 19 111111 333333 ", " 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 111111 222222 333333 444444 555555 666666 777777 888888 999999 ");
            //}

          
            //Console.WriteLine("END");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Recipe(2));
        }
    }
}
