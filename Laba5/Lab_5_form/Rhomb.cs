using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_5_form
{
    internal class Rhomb : Figure
    {
        public int HorDiagonal { get; set; }
        public int VerDiagonal { get; set; }

        public Rhomb(int x, int y, int horDiagonal, int verDiagonal) : base(x, y)
        {
            HorDiagonal = horDiagonal;
            VerDiagonal = verDiagonal;
        }
        public override void DrawBlack()
        {
            Form activeForm = Form1.ActiveForm;
            if (activeForm != null)
            {
                Graphics graphics = activeForm.CreateGraphics();
                Point[] points = new Point[] {
                new Point(X, Y - VerDiagonal / 2),
                new Point(X + HorDiagonal / 2, Y),
                new Point(X, Y + VerDiagonal / 2),
                new Point(X - HorDiagonal / 2, Y)};
                graphics.DrawPolygon(Pens.Black, points);
            }
        }

        public override void HideDrawingBackGround()
        {
            Form activeForm = Form1.ActiveForm;
            if (activeForm != null)
            {
                Graphics graphics = activeForm.CreateGraphics();
                Point[] points = new Point[] {
                new Point(X, Y - VerDiagonal / 2),
                new Point(X + HorDiagonal / 2, Y),
                new Point(X, Y + VerDiagonal / 2),
                new Point(X - HorDiagonal / 2, Y) };


                graphics.DrawPolygon(new Pen(activeForm.BackColor), points);
            }
        }



    }
}
