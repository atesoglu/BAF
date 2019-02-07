using System;
using System.Collections.Generic;
using BAF.Data.Store;
using BAF.Model.Actor;
using BAF.Model.Data;

namespace BAF.Konsole
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var a = BAF.App;
        }

        public class SampleObjectModel : ObjectModelBase
        {
            public string Name { get; set; }
        }

        public class SampleDomainModel : DomainModelBase
        {
            public string Name { get; set; }
        }

        public class SampleStore : StoreBase<SampleObjectModel, SampleDomainModel>
        {
            public override SampleObjectModel Get(int id)
            {
                throw new NotImplementedException();
            }

            public override SampleObjectModel Get(ICollection<int> ids)
            {
                throw new NotImplementedException();
            }

            public override SampleObjectModel Add(SampleObjectModel objectModel, IActorModel actor)
            {
                throw new NotImplementedException();
            }

            public override SampleObjectModel Update(SampleObjectModel objectModel, IActorModel actor)
            {
                throw new NotImplementedException();
            }

            public override SampleObjectModel Remove(SampleObjectModel objectModel, IActorModel actor)
            {
                throw new NotImplementedException();
            }
        }
    }
}