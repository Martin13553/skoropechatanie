using System.Diagnostics;

namespace ТЕСТ_НА_СКОРОПЕЧАТАНИЕ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name name = new Name();
            name.name = Console.ReadLine();
            Console.WriteLine(name.name);
            Console.Clear();

            List<string> text = new List<string>() { "Невский проспект есть всеобщая коммуникация Петербурга. Здесь житель Петербургской или Выборгской части, несколько лет не бывавший у своего приятеля на Песках или у Московской заставы, может быть уверен, что встретится с ним непременно. Никакой адрес-календарь и справочное место не доставят такого верного известия, как Невский проспект." };
            var rand = new Random();
            int tex = rand.Next(0,2);
            string textvv = text[tex];
            Console.WriteLine(textvv);
                        
            int i = 0;
            Console.SetCursorPosition(0, 0);
            while (i < textvv.Length)
            {                
                char c = Console.ReadKey(true).KeyChar;
                if (c == textvv[i])
                {
                    i++;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write(c);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }        
    }
}