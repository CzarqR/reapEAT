using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reapEAT
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ButMeal_Click(object sender, EventArgs e)
        {
            Hide();
            Main main = new Main();
            main.ShowDialog();
            Close();
        }

        private void ButCredits_Click(object sender, EventArgs e)
        {

        }

        private void ButDiets_Click(object sender, EventArgs e)
        {
            Hide();
            Diet diet = new Diet();
            diet.ShowDialog();
            Close();
        }

        private void ButSettings_Click(object sender, EventArgs e)
        {

        }

        private void ButFridge_Click(object sender, EventArgs e)
        {
            Hide();
            Fridge fridge = new Fridge();
            fridge.ShowDialog();
            Close();
        }

        private void ButProfile_Click(object sender, EventArgs e)
        {

        }

        private void ButLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
            Close();
        }
    }
}
