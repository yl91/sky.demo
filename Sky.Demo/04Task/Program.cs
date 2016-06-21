using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task task = Task.Run(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine(i);       
            //    }
            //});
            ////task.Wait();

            //Task t = Task.Run(() => {
            //    Random rnd = new Random();
            //    long sum = 0;
            //    int n = 1000000;
            //    for (int ctr = 1; ctr <= n; ctr++)
            //    {
            //        int number = rnd.Next(0, 101);
            //        sum += number;
            //    }
            //    Console.WriteLine("Total:   {0:N0}", sum);
            //    Console.WriteLine("Mean:    {0:N2}", sum / n);
            //    Console.WriteLine("N:       {0:N0}", n);
            //});
            //t.Wait();


            //Task task = Task.Factory.StartNew(() =>
            //{
            //    int ctr = 0;
            //    for (ctr = 0; ctr <= 1000000; ctr++)
            //    { }
            //    Console.WriteLine("Finished {0} loop iterations",
            //                      ctr);
            //});
            //task.Wait();

            Task<string> task=new Task<string>(() =>
            {
                return "abc";
            });
            task.Start();
            Console.WriteLine(task);

            
            


            //Task taskA = Task.Run(() => Thread.Sleep(2000));
            //Console.WriteLine("taskA Status: {0}", taskA.Status);
            //try
            //{
            //    taskA.Wait();
            //    Console.WriteLine("taskA Status: {0}", taskA.Status);
            //}
            //catch (AggregateException)
            //{
            //    Console.WriteLine("Exception in taskA.");
            //}

            Console.ReadKey();
        }
    }
}
