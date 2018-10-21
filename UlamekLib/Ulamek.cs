using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlamekLib
{
    public class Ulamek
    {
        private readonly long licznik = 0;
        private readonly long mianownik = 1;

        public long Licznik => licznik;
        /*
        {
            get
            {
                return licznik;
            }
        }
        */
        public long Mianownik => mianownik;

        public Ulamek(long licznik, long mianownik)
        {

            if (mianownik == 0)
                throw new DivideByZeroException("mianownik nie może być 0");

            this.mianownik = Math.Abs(mianownik);
            this.licznik = Math.Abs(licznik) * Math.Sign(licznik * mianownik);
            if (licznik == 0) this.mianownik = 1;
        }


        public Ulamek() : this(0 ,1) { }

        public Ulamek( long liczba ) : this(liczba, 1) { }

        public Ulamek( string napis )
        {
            //to do
            throw new NotImplementedException();
        }

        public Ulamek( double  liczba)
        {
            //to do
            throw new NotImplementedException();
        }

        public override string ToString() //=> $"{licznik}/{mianownik}";
        {
            return $"{licznik}/{mianownik}";
        }

    }
}
