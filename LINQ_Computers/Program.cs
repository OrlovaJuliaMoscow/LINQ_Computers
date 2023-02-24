using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Computers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer() { Num = 1, Name = "Bb", Type=11, Freq=3, Ram=32, VolHD=4, VolVideo=2, Summa = 100, Quantity = 30},
                new Computer() { Num = 2, Name = "Aa", Type=12, Freq=3, Ram=64, VolHD=8, VolVideo=1, Summa = 200, Quantity = 50},
                new Computer() { Num = 3, Name = "Dd", Type=11, Freq=3, Ram=128, VolHD=4, VolVideo=1, Summa = 100, Quantity = 10},
                new Computer() { Num = 4, Name = "Ee", Type=13, Freq=5, Ram=32, VolHD=8, VolVideo=2, Summa = 400, Quantity = 20},
                new Computer() { Num = 5, Name = "Cc", Type=12, Freq=4, Ram=32, VolHD=4, VolVideo=1, Summa = 200, Quantity = 4},
                new Computer() { Num = 6, Name = "Ff", Type=11, Freq=3, Ram=64, VolHD=2, VolVideo=2, Summa = 100, Quantity = 30}

            };

            Console.WriteLine("Type");
            int type = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.Type == type).ToList();
            Print(computers2);
            Console.ReadKey();

            Console.WriteLine("Ram");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers3 = computers.Where(x => x.Ram >= ram).ToList();
            Print(computers3);
            Console.ReadKey();

            List<Computer> computers4 = computers.OrderBy(x => x.Summa).ToList();
            Print(computers4);
            Console.ReadKey();


            IEnumerable<IGrouping<int, Computer>> computers5 = computers.GroupBy(x => x.Type).ToList();
            foreach (IGrouping<int, Computer> gr in computers5)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer c in gr)
                {
                    Console.WriteLine($"{c.Num} {c.Name} {c.Type} {c.Freq} {c.Ram} {c.VolHD} {c.VolVideo} {c.Summa} {c.Quantity}");
                }
            }

            Computer computer6 = computers.OrderByDescending(x => x.Summa).FirstOrDefault();
            Console.WriteLine($"{computer6.Num} {computer6.Name} {computer6.Type} {computer6.Num} {computer6.Ram} {computer6.VolHD} {computer6.VolVideo}  {computer6.Summa} {computer6.Quantity}");

            Computer computer7 = computers.OrderBy(x => x.Summa).FirstOrDefault();
            Console.WriteLine($"{computer7.Num} {computer7.Name} {computer7.Type} {computer7.Num} {computer7.Ram} {computer7.VolHD} {computer7.VolVideo}  {computer7.Summa} {computer7.Quantity}");


            Console.WriteLine(computers.Any(x => x.Quantity >= 30));
            Console.ReadKey();

        }
        static void Print(List<Computer> computers)
        {
            foreach (Computer c in computers)
            {
                Console.WriteLine($"{c.Num} {c.Name} {c.Type} {c.Freq} {c.Ram} {c.VolHD} {c.VolVideo} {c.Summa} {c.Quantity}");
            }
            Console.WriteLine();
        }
    }
}
