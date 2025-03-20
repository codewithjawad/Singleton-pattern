using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal class printer
    {
        static int counter = 0;
        private static printer instance = null;
        private printer()
        {
            counter++;
            Console.WriteLine("printer {0} running!!!", counter);
        }

        public static printer getaccess
        {
            get
            {
                if (instance==null)
                {
                    instance = new printer();
                }
                else
                {
                    Console.WriteLine("press 1 for stop printer and start another \n press to for stop printing process\n press 3 for continue printing");
                    Console.WriteLine("Enter choice: ");
                    int rep = int.Parse(Console.ReadLine());
                    if (rep == 1 )
                    {
                        instance = null;
                        Console.WriteLine("Printer Stopped!!!");
                        Console.WriteLine("Enter No of pages");
                        int gage = int.Parse(Console.ReadLine());
                        instance = new printer();
                        instance.Printing(gage);

                    }
                    else if (rep == 2)
                    {
                        Console.WriteLine("Printer Stopped");
                        instance = null;
                    }
                    else
                    {
                        Console.WriteLine("Continue printing.....");
                    }

                }
                
                return instance;
            }

        }

        public void Printing(int page)
        {
            Console.WriteLine("Printing ....");
        }
    }
}
