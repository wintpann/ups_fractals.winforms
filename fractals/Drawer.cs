using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fractals
{
    static class Drawer
    {
        static Graphics graphic;
        static TextBox amount, size;
        public static void GetControls(Graphics graphics)
        {
            graphic = graphics;
        }
        public static int dotSize = 2;
        public static int sleep = 0;
        static FractalMath.Point point = new FractalMath.Point();
        public static int dotsAmount = 30000;

        static Brush brush = new SolidBrush(Color.Green);
        static Brush backBrush = new SolidBrush(Color.Black);
        public static void ClearPanel()
        {
            graphic.Clear(Color.Black);
        }
        public static void DrawInitialPoint(int x, int y)
        {
            graphic.FillEllipse(Brushes.Yellow, x, y, dotSize, dotSize);
        }
        public static bool CreateFractal()
        {
            if (FractalMath.points.Count > 2)
            {
                int i = 0;
                Font font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                while (i < dotsAmount)
                {
                    point = FractalMath.GetNextPoint();
                    graphic.FillEllipse(brush, point.x, point.y, dotSize, dotSize);
                    graphic.FillRectangle(backBrush, 0, 0, 150, 20);
                    graphic.DrawString($"Dots: {i+1}", font, brush, 0, 0);
                    i++;
                    if (sleep > 0)
                    {
                        System.Threading.Thread.Sleep(sleep);
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
