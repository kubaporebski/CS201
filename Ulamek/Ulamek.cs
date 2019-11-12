using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpp.cs201
{
    /// <summary>
    /// Klasa reprezentująca ułamek w postaci kanonicznej, tj. licznik-mianownik.
    /// Pozwala na łatwe konwersje do liczb innego typu (double, int, itp. - TODO)
    /// </summary>
    public class Ulamek
    {
        /// <summary>
        /// Licznik liczy. Jest to ta liczba nad kreską ułamkową.
        /// </summary>
        public int Licznik { get; private set; }

        /// <summary>
        /// Mianownik mianuje. Jest to ta liczba pod kreską ułamkową. 
        /// Nie będzie nigdy zerem.
        /// </summary>
        public int Mianownik { get; private set; }

        /// <summary>
        /// Konstruktor domyślny konstruuje ułamek 0/1.
        /// </summary>
        public Ulamek() : this(0, 1)
        {
        } 


        /// <summary>
        /// Konstruktor jednoargumentowy konstruuje ułamek postaci [liczba]/1.
        /// </summary>
        /// <param name="liczba"></param>
        public Ulamek(int liczba) : this(liczba, 1)
        {
        }

        /// <summary>
        /// Konstruktor dwuargumentowy przyjmuje odpowiednio licznik i mianownik.
        /// Sprawdzane jest czy aby mianownik nie jest 0 (pamiętaj chemiku młody, nie dziel przez zero...)!
        /// </summary>
        /// <param name="licznik"></param>
        /// <param name="mianownik"></param>
        public Ulamek(int licznik, int mianownik)
        {
            if (mianownik == 0)
                throw new ArgumentException(nameof(mianownik));

           // TODO NWD

            Licznik = licznik;
            Mianownik = mianownik;
        }

        /// <summary>
        /// Zwrócenie ułamka w postaci tekstowej [znak][licznik]/[mianownik].
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var znak = Math.Sign(Licznik) * Math.Sign(Mianownik) == -1 ? "-" : "";
            var licz = Math.Abs(Licznik);
            var mian = Math.Abs(Mianownik);
            return $"{znak}{licz}/{mian}";
        }

    }
}
