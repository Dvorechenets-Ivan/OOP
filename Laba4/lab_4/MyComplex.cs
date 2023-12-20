using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class MyComplex : IMyNumber<MyComplex>
    {
        private double re;
        private double mi;

        public MyComplex(double re, double mi)
        {
            this.re = re;
            this.mi = mi;
        }

        public MyComplex Add(MyComplex that)
        {
            return new MyComplex(this.re + that.re, this.mi + that.mi);

        }

        public MyComplex Subtract(MyComplex that)
        {
            return new MyComplex(this.re - that.re, this.mi - that.mi);
        }

        public MyComplex Multiply(MyComplex that)
        {
            return new MyComplex(((this.re * that.re) - (this.mi * that.mi)), (this.re * that.mi) + (this.mi * that.re));
        }

        public MyComplex Divide(MyComplex that)
        {
            if (that.re == 0)
            {

                throw new DivideByZeroException();

            }
            return new MyComplex((((this.re * that.re) + (this.mi * that.mi)) /
                               (Math.Pow(that.re, 2) + Math.Pow(that.mi, 2))),

                               (((this.mi * that.re) - (this.re * that.mi)) /
                               (Math.Pow(that.re, 2) + Math.Pow(that.mi, 2))));



        }
        public override string ToString()
        {
            return $"{re} + {mi}i";
        }
    }
}
