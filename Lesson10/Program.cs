using System;
using m;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Lesson10
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 14.1");
            new Bank().DumpToScreen();

            Console.WriteLine("\nУпражнение 14.2");
            foreach (var attr in typeof(RationalCount).GetCustomAttributes(false))
            {
                if (attr is DeveloperInfoAttribute)
                {
                    DeveloperInfoAttribute devAttr = attr as DeveloperInfoAttribute;
                    Console.WriteLine($"{devAttr.Name} {devAttr.Time:dd.MM.yyyy HH:mm:ss}");
                }
            }
            Console.WriteLine("\nУпражнение 14.3");
            foreach (var attr in typeof(Bank).GetCustomAttributes(false))
            {
                if (attr is DevelopementInfoAttribute)
                {
                    DevelopementInfoAttribute devAttr = attr as DevelopementInfoAttribute;
                    Console.WriteLine($"Имя:{devAttr.Name} Организация:{devAttr.Organisation}");
                }
            }

        }
    }
}
