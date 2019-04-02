using System.Drawing;
using System.Windows.Forms;

namespace SierpinskiTriangleDrawing
{
    public static class Program
    {
        public static void Main()
        {
            Application.Run(new MyForm() { ClientSize = new Size(700, 700) });
        }
    }
}
