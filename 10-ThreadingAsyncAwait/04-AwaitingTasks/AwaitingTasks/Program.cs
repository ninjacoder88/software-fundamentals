using System;
using System.Threading.Tasks;

namespace AwaitingTasks
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            Runner r = new Runner();
            //r.Run();

            AsyncRunner ar = new AsyncRunner();
            await ar.RunAsync();
        }
    }
}
