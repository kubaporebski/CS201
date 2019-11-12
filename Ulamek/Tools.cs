using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpp.cs201
{
    /// <summary>
    /// Klasa z narzędziami.
    /// Zawiera metody pomocnicze, które nie wchodzą bezpośrednio w kompetencje klasy Ułamek, ale z których owa klasa korzysta.
    /// </summary>
    public static class Tools
    {
        /// <summary>
        /// Wyliczenie NWD metodą Euklidesa.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int NWD(int a, int b)
        {
            int tmp;
            while (b != 0)
            {
                tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;


        }
    }
}
