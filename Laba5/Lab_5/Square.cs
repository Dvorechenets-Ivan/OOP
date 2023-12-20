using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Square : Figure
    {
        public int SideLength { get; set; }

        public Square(int x, int y, int sideLength) : base(x, y)
        {
            SideLength = sideLength;
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
            Console.WriteLine($"Moving the square at ({X}, {Y}) to the right");
            X += 1;
        }

    }
}
