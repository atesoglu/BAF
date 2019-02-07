using System;
using BAF.Ioc;

namespace BAF.Service.SimpleInjector
{
    public static class IBAFBuilderExtensions
    {
        public static IBAFBuilder AddSimpleInjector(this IBAFBuilder bafBuilder)
        {
            //bafBuilder.App.Ioc = new BAFIoc();
            
            return bafBuilder;
        }
    }
}