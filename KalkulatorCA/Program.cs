using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorCA
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, wynik;
            string operacja = "";

            Console.WriteLine("-----Kalkulator-----");

            while (operacja != "exit")
            {
                Console.WriteLine("Podaj pierwszą liczbę: ");
                a = Convert.ToDouble(Console.ReadLine());

                while (operacja != "clear")
                {
                    Console.WriteLine("Podaj działanie(/,*,-,+), wyczyść za pomocą 'clear' lub wyjdź za pomocą 'exit': ");
                    operacja = Console.ReadLine();

                    if (operacja == "exit") Environment.Exit(-1);
                    if (operacja == "clear")
                    {
                        operacja = "";
                        break;
                    }

                    Console.WriteLine("Podaj kolejną liczbę: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    if (operacja == "/")
                    {
                        wynik = a / b;
                        Console.WriteLine("Wynik: " + wynik);
                        a = wynik;
                    }
                    if (operacja == "*")
                    {
                        wynik = a * b;
                        Console.WriteLine("Wynik: " + wynik);
                        a = wynik;
                    }
                    if (operacja == "-")
                    {
                        wynik = a - b;
                        Console.WriteLine("Wynik: " + wynik);
                        a = wynik;
                    }
                    if (operacja == "+")
                    {
                        wynik = a + b;
                        Console.WriteLine("Wynik: " + wynik);
                        a = wynik;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
