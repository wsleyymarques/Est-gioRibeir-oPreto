using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
    //2) Escreva um programa que verifique, em uma string, a existência da letra
    //‘a’, seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre.

    //IMPORTANTE: Essa string pode ser informada através de qualquer entrada de sua preferência ou
    //pode ser previamente definida no código;

{
    static void Main()
    {
        string input = " string de exemplo para verificar a letra 'a'.";
        int count = 0;

        foreach (char c in input)
            if (c == 'a' || c == 'A') count++;

        Console.WriteLine("A letra 'a' aparece {count} vez(es) na string.");
        Console.ReadKey();
    }
}
