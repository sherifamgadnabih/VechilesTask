using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using Vechiles.Data.Context;
using Vechiles.DTO;
using Vechiles.Models;
using Vechiles.Repository;
using Vechiles.Specification;

namespace Vechiles.Web
{
   
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

           
            var container = RegisterAutoFacInjections();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterAutoFacInjections()
        {
            var builder = new ContainerBuilder();
             builder.RegisterType<VechilesDataContext>().As<DbContext>();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Vechile, VechileDTO>();
            });
            builder.RegisterInstance(config)
                .As<IConfigurationProvider>();
                
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterGeneric(typeof(Specification<>)).As(typeof(ISpecification<>));
            builder.RegisterType(typeof(UnitOfWorkFactory)).As(typeof(IUnitOfWorkFactory));
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork));
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            return builder.Build();
        }
    }
}
