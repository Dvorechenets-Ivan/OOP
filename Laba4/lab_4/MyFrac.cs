using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Lab_4
{
    public class MyFrac : IMyNumber<MyFrac>, IComparable<MyFrac>
    {
        private BigInteger nom;
        private BigInteger denom;

        public MyFrac(int nom, int denom)
        {
            this.nom = nom;
            this.denom = denom;
            Simplify();
        }

        public MyFrac(BigInteger nom, BigInteger denom)
        {
            this.nom = nom;
            this.denom = denom;
            Simplify();
        }

        private static BigInteger GCD(BigInteger a, BigInteger b)
        {
            return BigInteger.GreatestCommonDivisor(a, b);
        }

        private void Simplify()
        {
            BigInteger gcd = GCD(nom, denom);
            nom /= gcd;
            denom /= gcd;
        }

        public MyFrac Add(MyFrac that)
        {
            MyFrac result = new MyFrac(BigInteger.Add(BigInteger.Multiply(nom, that.denom),
                                       BigInteger.Multiply(denom, that.nom)),
                                       BigInteger.Multiply(denom, that.denom));
            result.Simplify();
            return result;
        }

        public MyFrac Subtract(MyFrac that)
        {
            MyFrac result = new MyFrac(BigInteger.Subtract(BigInteger.Multiply(nom, that.denom),
                                       BigInteger.Multiply(denom, that.nom)),
                                       BigInteger.Multiply(denom, that.denom));
            result.Simplify();
            return result;
        }

        public MyFrac Multiply(MyFrac that)
        {
            MyFrac result = new MyFrac(BigInteger.Multiply(nom, that.nom),
                                       BigInteger.Multiply(denom, that.denom));
            result.Simplify();
            return result;
        }

        public MyFrac Divide(MyFrac that)
        {
            if (denom == 0)
            {
                throw new DivideByZeroException();
            }

            MyFrac result = new MyFrac(BigInteger.Multiply(nom, that.denom),
                                       BigInteger.Multiply(denom, that.nom));
            result.Simplify();
            return result;
        }
        public override string ToString()
        {
            return $"{nom} / {denom}";
        }


        public int CompareTo(MyFrac that)
        {

            MyFrac thisNormalized = new MyFrac(nom, denom);
            MyFrac thatNormalized = new MyFrac(that.nom, that.denom);

            thisNormalized.Simplify();
            thatNormalized.Simplify();

            return (int)(thisNormalized.nom * thatNormalized.denom - thisNormalized.denom * thatNormalized.nom);
        }

    }

}
