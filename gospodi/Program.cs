using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gospodi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printable[] printables = new Printable[6];
            printables[0] = new Book("превращение");
            printables[1] = new Magazine("все звезды");
            printables[2] = new Book("дракула");
            printables[3] = new Magazine("садовод");
            printables[4] = new Book("мы");
            printables[5] = new Magazine("я не могу придумать название");

            foreach (Printable printable in printables)
            {
                printable.Print();
            }
            Console.WriteLine("\n СОРТИРОВКА");
            Console.WriteLine("\n ЖУРНАЛЫ: \n");
            Book.PrintBooks(printables);
            Console.WriteLine("\n КНИГИ: \n");
            Magazine.PrintMagazine(printables);

            Console.ReadKey();
        }
        
    }
}
