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

            App.Context.ConfigureServices();
            App.Context.RegisterIocComponents();
            App.Context.Configure();
            App.Context.Verify();

            Console.WriteLine($"Elapsed: {sw.Elapsed}");
            Console.Read();
        }
    }
}