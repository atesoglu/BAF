using System;
using AutoMapper;
using BAF.Exceptions;
using BAF.Exceptions.Service.Core;

namespace BAF.Service.Core.Mapper
{
    public class AutoMapperImpl : IBAFMapper
    {
        private IMapperConfigurationExpression _expression;

        public AutoMapperImpl()
        {
            AutoMapper.Mapper.Initialize((expression => _expression = expression));
        }

        public void RegisterProfile<TProfile>() where TProfile : MapperProfile, new()
        {
            _expression.AddProfile<TProfile>();
        }

        public void Configure()
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
            return AutoMapper.Mapper.Map<TDestination>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return AutoMapper.Mapper.Map<TSource, TDestination>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return AutoMapper.Mapper.Map(source, destination);
        }
    }
}