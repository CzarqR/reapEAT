﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reapEAT
{
    static class DisplayElements
    {
        public static void DisplayAll(List<Label> controls, Form form, int startX, int startY, int incrementX, int incrementY)
        {
            int i = 0;
            foreach (Label label in controls)
            {
                label.Location = new Point(startX + (i * incrementX), startY + (i * incrementY));
                form.Controls.Add(label);
                i++;
            }
        }

        public static void ChangeLocation(List<Label> controls, int startX, int startY, int spaceX, int spaceY)
        {
            if (controls.Count == 0)
                return;
            controls[0].Location = new Point(startX, startY);
            for (int i = 1; i < controls.Count; i++)
            {
                controls[i].Location = new Point(controls[i - 1].Location.X + controls[i - 1].Size.Width + spaceX, controls[i - 1].Location.Y);
            }
        }

    }
}
