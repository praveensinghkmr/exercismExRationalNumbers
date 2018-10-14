using System;
using System.Collections.Generic;
using System.Text;

namespace RationalNumbers.ExtMethods
{
    public static class ExtMethods
    {
        public static RationalNumber Reduce(this RationalNumber r)
        {
            if (r.numerator == 0) return new RationalNumber(0, 1);
            int gcd = Gcd(Math.Abs(r.numerator), Math.Abs(r.denominator));
            if (gcd == 0)
                return r;
            r.numerator /= gcd;
            r.denominator /= gcd;
            return r;
        }

        private static int Gcd(int a, int b)
        {
            if (a == 0 || b == 0)
                return 0;
            if (a == b)
                return a;
            if (a > b)
                return Gcd(a - b, b);
            return Gcd(a, b - a);
        }
    }
    
}
