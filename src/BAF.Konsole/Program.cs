using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;

namespace BAF.Konsole
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sw = new Stopwatch();

            sw.Start();

            App.Context.PostRegisterIocComponents += (s, e) =>
            {
                App.Context.Ioc.Register<IStore, Store>(Service.Core.Ioc.Lifetimes.Singleton);
            };
            App.Context.PreConfigure += (s, e) => { App.Context.Mapper.RegisterProfile<Profiler>(); };
            App.Context.PostConfigure += (s, e) => { };
            App.Context.PostVerify += (s, e) =>
            {
                using (var context = new DataContext())
                {
                    context.Database.EnsureCreated();

                    if (context.ObjectCollection.FirstOrDefault() == null)
                    {
                        for (int i = 0; i < 1000; i++)
                        {
                            context.ObjectCollection.Add(new DomainModel { LookupId = i, Code = i.ToString(), Name = "Name" + i.ToString() });
                        }
                        context.SaveChanges();
                    }
                }

                var store = App.Context.Ioc.Resolve<IStore>();

                var predicates = new List<Expression<Func<DomainModel, bool>>> { w => w.LookupId > 40 };
                var models = store.Get(predicates, null, q => q.OrderByDescending(o => o.LookupId).ThenByDescending(o => o.Name), 0, 17);
                var a = e;
            };

            App.Context.ConfigureServices();
            App.Context.RegisterIocComponents();
            App.Context.Configure();
            App.Context.Verify();

            Console.WriteLine($"Elapsed: {sw.Elapsed}");
            Console.Read();
        }
    }
}