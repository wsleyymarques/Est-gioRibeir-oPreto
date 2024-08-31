using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Program
//5) Você está em uma sala com três interruptores, cada
//um conectado a uma lâmpada em salas diferentes. Você não
//pode ver as lâmpadas da sala em que está, mas pode ligar e
//desligar os interruptores quantas vezes quiser. Seu objetivo
//é descobrir qual interruptor controla qual lâmpada. Como você
//faria para descobrir, usando apenas duas idas até uma das salas
//das lâmpadas, qual interruptor controla cada lâmpada?  
{
    static void Main()
    {
        // Simula o processo
        SimularInterruptores();

        Console.ReadKey();
    }

    static void SimularInterruptores()
    {
        // Ligar Interruptor A e esperar 5 segundos
        Console.WriteLine("Ligar Interruptor A...");
        Thread.Sleep(5000);

        // Desligar Interruptor A e ligar Interruptor B
        Console.WriteLine("Desligar Interruptor A e ligar Interruptor B.");

        // Estado das lâmpadas após os interruptores
        string[] estados = { "Desligada e quente", "Ligada", "Desligada e fria" };

        Console.WriteLine("Lâmpada 1: " + estados[0]);
        Console.WriteLine("Lâmpada 2: " + estados[1]);
        Console.WriteLine("Lâmpada 3: " + estados[2]);

        Console.WriteLine("Resultado:");
        Console.WriteLine("Interruptor A controla a lâmpada que está desligada e quente.");
        Console.WriteLine("Interruptor B controla a lâmpada que está ligada.");
        Console.WriteLine("Interruptor C controla a lâmpada que está desligada e fria.");
    }
}
