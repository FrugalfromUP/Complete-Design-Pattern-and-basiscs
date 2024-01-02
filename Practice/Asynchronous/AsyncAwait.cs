using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice.Asynchronous
{
    public class AsyncAwait
    {
        static async Task Main()
        {
            await AsyncMethod();
        }

        public async static Task AsyncMethod()
        {
            await Console.Out.WriteLineAsync("start calling async method");
            Task.Delay(10000);
            Console.Out.WriteLineAsync("asysnc method called");
            Console.WriteLine("After async method called");
            Console.ReadLine();
        }

    }
}
