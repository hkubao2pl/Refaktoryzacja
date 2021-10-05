using System;
using System.Linq;

namespace Refaktoryzacja
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Stop [s]");
                Console.WriteLine("Wypłać [wy]");
                Console.WriteLine("Wpłać [wp]");
                var akcja = Console.ReadLine();
                if (akcja == "s")
                {
                    break;
                }
                else if (akcja == "wy" || akcja == "wp")
                {
                    Console.WriteLine("Podaj id klienta:");
                    try
                    {
                        var id = Convert.ToInt32(Console.ReadLine());
                        var client = Repository.Clients.Where(c => c.Id == id).FirstOrDefault();
                        if (client == null)
                        {
                            Console.WriteLine("Błędne id!");
                        }
                        else
                        {
                            try
                            {
                                Console.WriteLine("Podaj kowotę!");
                                var kwota = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(client.DoOperation(akcja, kwota));
                            }
                            catch
                            {
                                Console.WriteLine("Błędna kowota!");
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Błędne id!");
                    }
                }
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("");
            }
        }
    }
}
