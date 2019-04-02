using System;
using System.Drawing;
using System.Windows.Forms;

namespace SierpinskiTriangleDrawing
{
    public class MyForm : Form
    {
        private new void Move(ref int x, ref int y, int newX, int newY)
        {
            x = (newX + x) / 2;
            y = (newY + y) / 2;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            int x = 100;
            int y = 100;
            var Rnd = new Random();
            for (int i = 0; i < 100000; i++)
            {
                g.FillRectangle(Brushes.Purple, x, y, 1, 1);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                var r = Rnd.Next(1, 30);
                if (r < 10)
                {
                    Move(ref x, ref y, 100, 500);
                }
                else if (r < 20)
                {
                    Move(ref x, ref y, 600, 500);
                }
                else
                {
                    Move(ref x, ref y, 350, 100);
                }
            }
            g.FillRectangle(Brushes.Aqua, x, y, 1, 1);
        }
    }
}