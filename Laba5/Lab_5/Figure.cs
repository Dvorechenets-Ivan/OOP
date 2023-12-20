using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public abstract class Figure
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();
        public abstract void MoveRight();

        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }


    }
}
