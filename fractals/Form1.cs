using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fractals
{
    public partial class Form1 : Form
    {
        bool addingPoints = false;
        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            Drawer.GetControls(graphics = panel1.CreateGraphics());
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            coordinates.Text = e.X.ToString() + " " + e.Y.ToString();
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (addingPoints)
            {
                FractalMath.HandPoint(e.X, e.Y);
            }
            
        }

        private void createPoints_Click(object sender, EventArgs e)
        {
            if (addingPoints)
            {
                dotsAmountTextBox.Enabled = true;
                dotsSizeTextBox.Enabled = true;
                
                addingPoints = !addingPoints;
                createPoints.Text = "Create NEW points";
            }
            else
            {
                FractalMath.ClearInitialPoints();
                Drawer.ClearPanel();
                dotsAmountTextBox.Enabled = false;
                dotsSizeTextBox.Enabled = false;
                createFractal.Enabled = true;
                addingPoints = !addingPoints;
                createPoints.Text = "Finish";
            }
            
        }

        private void createFractal_Click(object sender, EventArgs e)
        {
            if (!addingPoints)
            {
                createFractal.Enabled = false;
                bool success = Drawer.CreateFractal();
                if (!success)
                {
                    MessageBox.Show("It needs more than 2 initial points");
                    createFractal.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Finish create point mode");
            }
        }

        private void dotsAmountTextBox_Leave(object sender, EventArgs e)
        {
            int amount = 0;
            bool success = true;
            try
            {
                amount = Convert.ToInt32(dotsAmountTextBox.Text);
            }
            catch
            {
                success = false;
                dotsAmountTextBox.Text = "30000";
                MessageBox.Show("Invalid value");
            }
            if (success)
            {
                Drawer.dotsAmount = amount;
            }
        }

        private void dotsSizeTextBox_Leave(object sender, EventArgs e)
        {
            int size = 0;
            bool success = true;
            try
            {
                size = Convert.ToInt32(dotsSizeTextBox.Text);
            }
            catch
            {
                success = false;
                dotsSizeTextBox.Text = "2";
                MessageBox.Show("Invalid value");
            }
            if (success)
            {
                if (size < 2)
                {
                    MessageBox.Show("Value must be equal or greater than 2");
                }
                Drawer.dotSize = size;
            }
        }

        private void multiplierTextBox_Leave(object sender, EventArgs e)
        {
            double multiplier = 0.5;
            bool success = true;
            try
            {
                multiplier = Convert.ToDouble(multiplierTextBox.Text);
            }
            catch
            {
                success = false;
                multiplierTextBox.Text = "0.5";
                MessageBox.Show("Invalid value");
            }
            if (success)
            {
                if (multiplier >= 1 || multiplier <= 0)
                {
                    MessageBox.Show("Value must be between 0 and 1");
                    multiplierTextBox.Text = "0.5";
                }
                else
                {
                    FractalMath.multiplier = multiplier;
                }
            }
        }

        private void sleepTextBox_Leave(object sender, EventArgs e)
        {
            int sleep = 0;
            bool success = true;
            try
            {
                sleep = Convert.ToInt32(sleepTextBox.Text);
            }
            catch
            {
                success = false;
                sleepTextBox.Text = "0";
                MessageBox.Show("Invalid value");
            }
            if (success)
            {
                if (sleep < 0 )
                {
                    MessageBox.Show("Value must be equal or greater than 0");
                    sleepTextBox.Text = "0";
                }
                else
                {
                    Drawer.sleep = sleep;
                }
            }
        }
    }
}

