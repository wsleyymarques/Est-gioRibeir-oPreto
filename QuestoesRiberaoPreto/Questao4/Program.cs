using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
    //4) Descubra a lógica e complete o próximo elemento:
    //a) 1, 3, 5, 7, ___
    //b) 2, 4, 8, 16, 32, 64, ____
    //c) 0, 1, 4, 9, 16, 25, 36, ____
    //d) 4, 16, 36, 64, ____
    //e) 1, 1, 2, 3, 5, 8, ____
    //f) 2,10, 12, 16, 17, 18, 19, ____
{
    static void Main()
    {
        Console.WriteLine("a) " + (1 + 6 * 2));  //  9
        Console.WriteLine("b) " + 64 * 2);      //  128
        Console.WriteLine("c) " + 49);          //  49 (7²)
        Console.WriteLine("d) " + 100);         //  100 (10²)
        Console.WriteLine("e) " + (8 + 5));     //  13 (Fibonacci)
        Console.WriteLine("f) " + ProximoNumeroF());
    }

    static int ProximoNumeroF()
    {
        for (int i = 20; ; i++) if (!i.ToString().Contains("1")) return i;
    }
}
