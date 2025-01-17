using System;

namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        // TODO: fill this class\
       /* private readonly int _imaginaryPart; 
        private readonly int _realPart;*/
        public double Imaginary { get; }

        public double Real { get;}

        public double Modulus { get; set; }

        public double Phase { get; set; }

        public Complex(double realPart, double imaginaryPart) 
        {
            Real = realPart;
            Imaginary = imaginaryPart;
            Modulus = Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));
            Phase = Math.Atan2(Real, Imaginary);
        }
        
        public bool Equals(Complex compareNumber)
         {
            if( Real == compareNumber.Real && Imaginary == compareNumber.Imaginary) {
                return true;
            } else {
                return false;
            }  
        }

        public Complex Complement() {
            return new Complex(Real,(-1)*Imaginary);
        }

        public Complex Plus(Complex addNumber) 
        {
             return new Complex(Real+addNumber.Real, Imaginary);
        }
        public Complex Minus(Complex subNumber) 
        {
            return new Complex(Real - subNumber.Real, Imaginary - subNumber.Imaginary);
        }

        public string ToString() => $"Complex Number {this.GetType().Name}: Real = {Real} Imaginary = {Imaginary}";
    }
}