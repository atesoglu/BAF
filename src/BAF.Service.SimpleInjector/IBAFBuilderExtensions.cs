using System;
using BAF.Service.SimpleInjector.Implementation;

namespace BAF.Service.SimpleInjector
{
    public static class IBAFBuilderExtensions
    {
        public static IBAFBuilder AddSimpleInjector(this IBAFBuilder bafBuilder)
        {
            var builder = (BAFBuilder) bafBuilder;
            builder.SetIoc(new SimpleInjectorContainer());
            
            return bafBuilder;
        }
    }
}