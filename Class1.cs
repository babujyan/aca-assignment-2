using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2
{
    public struct Complex_number
    {
        public double Re;
        public double Im;
        public Complex_number(double Re, double Im)
        {
            this.Re = Re;
            this.Im = Im;
        }
    }

    class Complex
    {
        public Complex_number Number;
        
        public Complex(Complex_number n)
        {
            this.Number = n;
        }

        public static Complex_number add(Complex_number n1, Complex_number n2)
        {
            Complex_number output_number;
            output_number.Re = n1.Re + n2.Re;
            output_number.Im = n2.Im + n2.Im;
            return output_number;
        }
        public static Complex_number sub(Complex_number n1, Complex_number n2)
        {
            Complex_number output_number;
            output_number.Re = n1.Re - n2.Re;
            output_number.Im = n1.Im - n2.Im;
            return output_number;
        }
        public static Complex_number mult(Complex_number n1, Complex_number n2)
        {
            Complex_number output_number;
            output_number.Re = n1.Re * n2.Re;
            output_number.Im = n2.Im * n2.Im;
            return output_number;
        }
        public static Complex_number division(Complex_number n1, Complex_number n2)
        {
            Complex_number output_number;
            output_number.Re = n1.Re / n2.Re;
            output_number.Im = n2.Im / n2.Im;
            return output_number;
        }
        public static double absolute_value(Complex_number n)
        {
            Complex_number output_number;
            double output;
            output_number.Re = n.Re;
            output_number.Im = n.Im;
            output = Math.Pow(Math.Pow(output_number.Re, 2) + Math.Pow(output_number.Im, 2), 0.5);
            return output;
        }
        public static double arg(Complex_number n)
        {
            Complex_number output_number;
            double output;
            output_number.Re = n.Re;
            output_number.Im = n.Im;
            output = Math.Atan(output_number.Im / output_number.Re);
            return output;
        }
    }
}
