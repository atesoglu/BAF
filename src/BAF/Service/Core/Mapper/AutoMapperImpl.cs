using BAF.Exceptions.Service.Core;
using System;

namespace BAF.Service.Core.Mapper
{
    public class AutoMapperImpl : IBAFMapper
    {
        private AutoMapper.Configuration.MapperConfigurationExpression _expression;
        private AutoMapper.IMapper _mapper;

        public AutoMapperImpl()
        {
            _expression = new AutoMapper.Configuration.MapperConfigurationExpression();
        }

        public void RegisterProfile<TProfile>() where TProfile : MapperProfile, new()
        {
            _expression.AddProfile<TProfile>();
        }

        public void Configure()
        {
            //AutoMapper.Mapper.Initialize(_expression);

            var mapperConfig = new AutoMapper.MapperConfiguration(_expression);
            _mapper = new AutoMapper.Mapper(mapperConfig);
        }

        public void Verify()
        {
            try
            {
                AutoMapper.Mapper.AssertConfigurationIsValid();
            }
            catch (Exception ex)
            {
                throw new BAFMapperValidationException(ex);
            }
        }

        public TDestination Map<TDestination>(object source)
        {
            return _mapper.Map<TDestination>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TSource, TDestination>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return _mapper.Map(source, destination);
        }
    }
}