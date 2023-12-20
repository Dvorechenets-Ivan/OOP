using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter numberator: ");
            long numberator1 = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter denominator: ");
            long denominator1 = long.Parse(Console.ReadLine());*/

            Fraction fraction1 = new Fraction(3, 4);

            Console.WriteLine("Reduced fraction: {0}", fraction1);
            Console.WriteLine("Fraction with integer part: {0}", fraction1.ToStringWithIntPart());
            Console.WriteLine("Fraction as a double: {0} \n", fraction1.ToDouble());


            //Fnction 2

            /*Console.WriteLine("Enter numberator: ");
            long numberator2 = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter denominator: ");
            long denominator2 = long.Parse(Console.ReadLine());*/

            Fraction fraction2 = new Fraction(1, 4);

            Console.WriteLine("Reduced fraction: {0}", fraction2);
            Console.WriteLine("Fraction with integer part: {0}", fraction2.ToStringWithIntPart());
            Console.WriteLine("Fraction as a double: {0} \n", fraction2.ToDouble());

            //operator

            Fraction sum = fraction1 + fraction2;
            Console.WriteLine("\tSum : {0}", sum);


            Fraction difference = fraction1 - fraction2;
            Console.WriteLine("\tDifference : {0}", difference);


            Fraction multiply = fraction1 * fraction2;
            Console.WriteLine("\tMulriply : {0}", multiply);


            Fraction division = fraction1 / fraction2;
            Console.WriteLine("\tDivision : {0}", division);


            Console.ReadKey();
        }
    }
}
