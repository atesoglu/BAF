using BAF.Data.EFCore.Store;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;

namespace BAF.Konsole
{

    public class ObjectModel : Model.Data.ObjectModelBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public int LookupId { get; set; }
        public int SomeOtherId { get; set; }
    }
}