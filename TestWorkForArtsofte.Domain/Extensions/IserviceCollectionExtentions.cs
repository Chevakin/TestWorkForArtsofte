using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TestWorkForArtsofte.Domain.Data.DTOs.Mapping;

namespace TestWorkForArtsofte.Domain.Extensions
{
    public static class IserviceCollectionExtentions
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new EmployeeProfile());
                cfg.AddProfile(new DepartmentProfile());
                cfg.AddProfile(new ProgrammingLanguageProfile());
            });

            services.AddSingleton<IMapper, Mapper>(p => new Mapper(config));

            return services;
        }
    }
}
