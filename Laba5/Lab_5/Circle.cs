using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Circle : Figure
    {
        public int Radius { get; set; }

        public Circle(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }

        public override void DrawBlack()
        {
            throw new NotImplementedException();
        }

        public override void HideDrawingBackGround()
        {
            throw new NotImplementedException();
        }

        public override void MoveRight()
        {
            Console.WriteLine($"Moving the circle at ({X}, {Y}) to the right");
            X += 1;

        }
    }
}
