using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal class session
    {
        static int Counter = 0;
        private static session instance = null;
        static session()

        {
            Counter++;
            Console.WriteLine("session {0} running!", Counter);
        }

        public static session getaccess
        {
            get
            {
                if (instance == null)
                {
                    instance = new session();
                }
                else
                {
                    Console.WriteLine("press 1 for stop session and start another \n press 2 for close session process\n press 3 for continue session");
                    Console.WriteLine("Enter choice: ");
                    int rep = int.Parse(Console.ReadLine());
                    if (rep == 1)
                    {
                        instance = null;
                        Console.WriteLine("session Stopped!!!");
                        Console.WriteLine("Enter session name");
                        String name = Console.ReadLine();
                        instance = new session();
                        instance.sessionconduct(name);

                    }
                    else if (rep == 2)
                    {
                        Console.WriteLine("session closed");
                        instance = null;
                    }
                    else
                    {
                        Console.WriteLine("Continue session");
                    }

                }
                return instance;
            }

        }

        public void sessionconduct(String name)
        {
            Console.WriteLine("session continuing.. ");
        }
    }
}
