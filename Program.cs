// Zadanie 1

using System;

namespace Zadania_Tekstowe_1
{
    internal class Zadanie1
    {
        static void Main(string[] args)
        {
            // zadanie 1
            string zadanie1;
            string zadanie2;
            string question;
            string question2;
            string question3;
            Console.WriteLine("Podaj dowolne zdanie:");
            zadanie1 = Console.ReadLine();
            Console.WriteLine(zadanie1.Length);
            Console.WriteLine(zadanie1.ToUpper());
            Console.WriteLine(zadanie1.ToLower());
            // zadanie 1.1
            Console.WriteLine("Napisać twój tekst z wielkich czy z małych liter? Jeśli chcesz z wielkich liter, napisz 'L' a jeśli z małych 'l'");
            question = Console.ReadLine();
            if(question == "L")
            {
                Console.WriteLine(zadanie1.ToUpper());
            } else if(question == "l") {
                Console.WriteLine(zadanie1.ToLower());
            }
            // zadanie 1.2
            Console.WriteLine("Czy chcesz żeby napisał twój tekst z wielkiej czy z małej litery? Jeśli z wielkiej to napisz 'W' jeśli z małej napisz 'm'");
            question2 = Console.ReadLine();
            if(question2 == "W")
            {
                Console.WriteLine(zadanie1.Substring(0, 1).ToUpper() + zadanie1.Substring(1));
            } else if(question2 == "m"){
                Console.WriteLine(zadanie1.Substring(0, 1).ToLower() + zadanie1.Substring(1));
            }
            // zadanie 2
            Console.WriteLine("Podaj znowu dowolne zdanie");
            zadanie2 = Console.ReadLine();
            string nospace = zadanie2.Trim();
            Console.WriteLine(nospace.Length);
            Console.WriteLine(nospace.Substring(0, 1));
            Console.WriteLine(nospace.Substring(nospace.Length - 1));
        }
    }
}
