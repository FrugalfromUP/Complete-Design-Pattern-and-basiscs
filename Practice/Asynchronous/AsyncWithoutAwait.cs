using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class AsyncWithoutAwait
    {
        static async Task Main()
        {
            AsynchronousMethod();
            Console.WriteLine("Hello Sir Mai wait nhi kiya upar bale task ke complete hone ka qki aap await lagana bhul gye");
            Console.ReadKey();
        }

        public async static  Task AsynchronousMethod()

        {
            await Task.Delay(10000);
            await Console.Out.WriteLineAsync("Ritesh");
        }
    }
}
