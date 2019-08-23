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
        private Random rnd = new Random();
        public Menu()
        {
            InitializeComponent();
            butCredits.BackColor = Color.FromArgb(rnd.Next(206) + 25, rnd.Next(206) + 25, rnd.Next(206) + 25);
            butFridge.BackColor = Color.FromArgb(rnd.Next(206) + 25, rnd.Next(206) + 25, rnd.Next(206) + 25);
            butLogOut.BackColor = Color.FromArgb(rnd.Next(206) + 25, rnd.Next(206) + 25, rnd.Next(206) + 25);
            butProfile.BackColor = Color.FromArgb(rnd.Next(206) + 25, rnd.Next(206) + 25, rnd.Next(206) + 25);
            butSettings.BackColor = Color.FromArgb(rnd.Next(206) + 25, rnd.Next(206) + 25, rnd.Next(206) + 25);
            butMeal.BackColor = Color.FromArgb(rnd.Next(206) + 25, rnd.Next(206) + 25, rnd.Next(206) + 25);
            butDiets.BackColor = Color.FromArgb(rnd.Next(206) + 25, rnd.Next(206) + 25, rnd.Next(206) + 25);
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
            MessageBox.Show("App made by CezaryR, not very pretty but works", "Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("There are no settings yet, maybe in future", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            MessageBox.Show("Profile (not made yet)", "Profile(not made yet)", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
