using System;
using System.Threading;
using System.Threading.Tasks;

namespace JenkinsPipelineApp
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Starting...");
            Thread.Sleep(5000);
            Console.WriteLine("Done");
            return 0;
        }
    }
}
