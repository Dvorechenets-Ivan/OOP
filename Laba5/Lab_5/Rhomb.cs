using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Rhomb : Figure
    {
        public int HorDiagonal { get; set; }
        public int VerDiagonal { get; set;}

        public Rhomb(int x, int y, int horDiagonal, int verDiagonal) : base(x, y)
        { 
            HorDiagonal = horDiagonal;
            VerDiagonal = verDiagonal;
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
            Console.WriteLine($"Moving the rhomb at ({X}, {Y}) to the right");
            X += 1;
        }
    }
}
