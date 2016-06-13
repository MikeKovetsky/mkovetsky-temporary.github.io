using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();         
        }
          
        private void button1_Click_1(object sender, EventArgs e)
        {
            double dice, critical;
            double agility, enemylevel, range, luck;
            agility = (double)numericUpDown1.Value;
            enemylevel = (double)numericUpDown2.Value;
            range = (double)numericUpDown3.Value;
            luck = (double)numericUpDown4.Value;
            dice = 50 + (4 * enemylevel * (range / 1.3) - (agility + (luck / 1.1)));
            if (dice >= 95)
            {
                dice = 95;
                textBox1.Text = Convert.ToString(Math.Round(dice, 0));
            }
            else {
                textBox1.Text = Convert.ToString(Math.Round(dice, 0));
            }

            critical = 95 + (4 * enemylevel * (range / 1.3) - (agility + (luck)));
            textBox2.Text = Convert.ToString(Math.Round(critical, 0));
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double strength, damage, dice, result;
            strength = (double)numericUpDown5.Value;
            damage = (double)numericUpDown6.Value;
            dice = (double)numericUpDown7.Value;

            result = (damage + (strength * dice) / 60);
            textBox3.Text = Convert.ToString(Math.Round(result, 0));

        }
    }
}
   