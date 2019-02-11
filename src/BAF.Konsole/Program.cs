using System;
using System.Diagnostics;

namespace BAF.Konsole
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sw = new Stopwatch();

            sw.Start();

            BAF.App.ConfigureServices();
            BAF.App.RegisterIocComponents();
            BAF.App.Configure();
            BAF.App.Verify();

            Console.WriteLine($"Elapsed: {sw.Elapsed}");
            Console.Read();
        }
    }
}