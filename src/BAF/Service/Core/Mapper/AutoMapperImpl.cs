using BAF.Exceptions.Service.Core;
using System;

namespace BAF.Service.Core.Mapper
{
    public class AutoMapperImpl : IBAFMapper
    {
        private AutoMapper.MapperConfiguration _mapperConfiguration;
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

            _mapperConfiguration = new AutoMapper.MapperConfiguration(_expression);
            _mapper = new AutoMapper.Mapper(_mapperConfiguration);
        }

        public void Verify()
        {
            try
            {
                _mapperConfiguration.AssertConfigurationIsValid();
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