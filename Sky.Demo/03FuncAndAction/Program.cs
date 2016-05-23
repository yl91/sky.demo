using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03FuncAndAction
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ==Func:无论是否参数，只要有返回值的方法，都可以使用Func==
            Func<string> fn = delegate() { return "Hello World！"; };
            Console.WriteLine(fn());


            Func<string> fn2 = () => { return "Hello fn2！"; };
            Console.WriteLine(fn2());


            Func<int, int, string> fn3 = (x,y) =>
            {
                int num = x + y;
                return "fn3->"+num;
            };
            Console.WriteLine(fn3(2,3));

            string result= Count((x,y) => { return (x + y + 10).ToString(); });
            Console.WriteLine(result);
            #endregion



            Console.ReadKey();
        }

        static string Count(Func<int,int,string> func)
        {
            return string.Format("Count:{0}",func.Invoke(2,3));
        }

        //public Int64 Count(Func<IDateTimeSplitDatabase, Int64> execute)
        //{
        //    var tasks = selector.All.Select(m =>
        //    {
        //        var t = new Task<Int64>(() =>
        //        {
        //            return execute.Invoke(m);
        //        });
        //        t.Start();
        //        return t;
        //    });

        //    return Task.WhenAll(tasks).Result.Sum();
        //}
    }
}
