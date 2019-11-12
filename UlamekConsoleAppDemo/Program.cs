using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace kpp.cs201
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(new Ulamek());
            WriteLine(new Ulamek(42));
            WriteLine(new Ulamek(3, 4));
            WriteLine(new Ulamek(-1, 2));
            WriteLine(new Ulamek(2, -3));
            WriteLine(new Ulamek(1, 0));

        }
    }
}
