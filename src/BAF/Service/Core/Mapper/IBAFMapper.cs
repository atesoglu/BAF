namespace BAF.Service.Core.Mapper
{
    public interface IBAFMapper
    {
        void RegisterProfile<TProfile>() where TProfile : MapperProfile, new();
        void Configure();

        TDestination Map<TDestination>(object source);
        TDestination Map<TSource, TDestination>(TSource source);
        TDestination Map<TSource, TDestination>(TSource source, TDestination destination);
        void Verify();
    }
}