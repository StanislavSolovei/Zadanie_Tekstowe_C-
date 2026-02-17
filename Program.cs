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
            string zadanie3;
            string zadanie4;
            string question;
            string question2;
            string question3;
            string question4;
            char question5;
            Console.WriteLine("Zadanie 1. Podaj dowolne zdanie:");
            zadanie1 = Console.ReadLine();
            Console.WriteLine(zadanie1.Length);
            Console.WriteLine(zadanie1.ToUpper());
            Console.WriteLine(zadanie1.ToLower());
            // zadanie 1.1
            Console.WriteLine("Zadanie 1.1.Napisać twój tekst z wielkich czy z małych liter? Jeśli chcesz z wielkich liter, napisz 'L' a jeśli z małych 'l'");
            question = Console.ReadLine();
            if(question == "L")
            {
                Console.WriteLine(zadanie1.ToUpper());
            } else if(question == "l") {
                Console.WriteLine(zadanie1.ToLower());
            }
            // zadanie 1.2
            Console.WriteLine("Zadanie 1.2. Czy chcesz żeby napisał twój tekst z wielkiej czy z małej litery? Jeśli z wielkiej to napisz 'W' jeśli z małej napisz 'm'");
            question2 = Console.ReadLine();
            if(question2 == "W")
            {
                Console.WriteLine(zadanie1.Substring(0, 1).ToUpper() + zadanie1.Substring(1));
            } else if(question2 == "m"){
                Console.WriteLine(zadanie1.Substring(0, 1).ToLower() + zadanie1.Substring(1));
            }
            // zadanie 2
            Console.WriteLine("Zadanie 2. Podaj znowu dowolne zdanie");
            zadanie2 = Console.ReadLine();
            string nospace = zadanie2.Trim();
            Console.WriteLine(nospace.Length);
            Console.WriteLine(nospace.Substring(0, 1));
            Console.WriteLine(nospace.Substring(nospace.Length - 1));
            // zadanie 3
            Console.WriteLine("Zadanie 3. Wpisz znowu dowolny zdanie");
            zadanie4 = Console.ReadLine();
            Console.WriteLine("Wpisz znak dla wyszukiwania:");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Nie wpisałeś żadnego znaku.");
                return;
            }
            question5 = input[0];
            int licznik = 0;
            for(int i = 0; i < zadanie4.Length; i++)
            {
                if (zadanie4[i] == question5)
                {
                    licznik++;
                }
            }
            Console.WriteLine($"Litera '{question5}' występuje {licznik} razy");
            // zadanie 4
            Console.WriteLine("Zadanie 4. Podaj znowu dowolne zdanie");
            zadanie3 = Console.ReadLine();
            Console.WriteLine("Czy chcesz zmienić spację na dowolny ci znak?");
            question4 = Console.ReadLine();
            if(question4 == "Tak")
            {
                Console.WriteLine("Napisz jaki chcesz znak:");
                string znak = Console.ReadLine();
                zadanie3 = zadanie3.Replace(" ", znak);
                Console.WriteLine(zadanie3);
            } else if(question4 == "Nie")
            {
                string answer = "Okej, spoko";
                Console.WriteLine(answer);
            }
        }
    }
}
