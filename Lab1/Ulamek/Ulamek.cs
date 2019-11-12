using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace kpp.cs201.lab1
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
        /// Konstruktor jednoargumentowy konstruuje ułamek postaci [liczba]/1.
        /// </summary>
        /// <param name="liczba"></param>
        public Ulamek(double liczba) : this((int)liczba)
        {
        }

        /// <summary>
        /// Konstruktor jednoargumentowy przyjmuje postać tekstową ułamka.
        /// </summary>
        /// <param name="liczba"></param>
        public Ulamek(string liczba)
        {
            int[] czesci = Parse(liczba);
            Licznik = czesci[0];
            Mianownik = czesci[1];
        }

        /// <summary>
        /// Konstruktor dwuargumentowy przyjmuje odpowiednio licznik i mianownik.
        /// Sprawdzane jest czy aby mianownik nie jest 0 (pamiętaj chemiku młody, nie dziel przez zero...)!
        /// </summary>
        /// <param name="licznik"></param>
        /// <param name="mianownik"></param>
        public Ulamek(int licznik, int mianownik) : this(licznik, mianownik, true)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="licznik"></param>
        /// <param name="mianownik"></param>
        /// <param name="uprosc"></param>
        private Ulamek(int licznik, int mianownik, bool uprosc)
        {
            if (mianownik == 0)
                throw new ArgumentException(nameof(mianownik));

            int nwd = uprosc
                ? Tools.NWD(Math.Abs(licznik), Math.Abs(mianownik))
                : 1;

            Licznik = licznik / nwd;
            Mianownik = mianownik / nwd;
        }

        public int[] Parse(string liczba)
        {
            if (liczba == null)
                throw new ArgumentException(nameof(liczba) + " nie może być null");

            liczba = liczba.Trim();
            var znalezione = Regex.Match(liczba, @"(-?[0-9]+)/(-?[0-9]+)");
            if (!znalezione.Success)
                throw new ArgumentException(nameof(liczba) + " jest w złej postaci");

            return new int[] {
                int.Parse(znalezione.Groups[1].Value),
                int.Parse(znalezione.Groups[2].Value)
            };
        }

        /// <summary>
        /// Zwrócenie ułamka w postaci tekstowej [znak][licznik]/[mianownik].
        /// Znak jest wypisywany wtedy tylko, gdy liczba, którą ułamek reprezentuje, jest mniejsza od zera.
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
