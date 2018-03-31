using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;    // Namespace use for Task(Task has features more than thread)
using System.Threading;         //  Namepsace use for Threading

namespace Threading_And_Task
{
    class Program
    {
        static Task task1;
        static void Main(string[] args)
        {
            task1 = new Task(Hello);
            Task taks2 = new Task(Bye);
            //Thread thread = new Thread(Hello);
            //Task<int> task3 = new Task<int>(() => HelloAgain("Hello"));
           // int x = task3.Result;

            task1.Start();
            taks2.Start();
            //task3.Start();
            Console.ReadLine();
        }

        static void Hello()
        {
            for(int I = 0; I<100; I++)
            {
                Console.WriteLine("Hello");
            }
        }

        static void Bye()
        {
            for(int J=0; J<100; J++)
            {
                Console.WriteLine("Bye");
            }
        }

        static int HelloAgain(string x)
        {
            task1.Wait();
            for(int i=0; i<100; i++)
            {
                Console.WriteLine("Hello Again");
            }
            return 1;
        }
    }
}
