using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Complex_number n1 = new Complex_number(1,2);
            Complex_number n2 = new Complex_number(3,1);

            Console.WriteLine(Complex.add(n1, n2).Re);
            Console.WriteLine(Complex.sub(n1, n2).Im);
            Console.WriteLine(Complex.mult(n1, n2).Re);
            Console.WriteLine(Complex.absolute_value(n1));
            Console.WriteLine(Complex.absolute_value(n2));
            Console.WriteLine(Complex.arg(n1));
            Console.WriteLine(Complex.arg(n2));
        }
    }
}
