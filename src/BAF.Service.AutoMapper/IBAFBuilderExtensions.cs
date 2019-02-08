namespace BAF.Service.AutoMapper
{
    public static class IBAFBuilderExtensions
    {
        public static IBAFBuilder AddAutoMapper(this IBAFBuilder bafBuilder)
        {
            var builder = (BAFBuilder)bafBuilder;

            return builder;
        }
    }
}