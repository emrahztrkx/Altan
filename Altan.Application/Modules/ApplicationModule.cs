using System.Reflection;
using Altan.Core;
using Altan.Core.Shared.Dependency;
using Altan.EntityFramework;
using Autofac;
using Module = Autofac.Module;

namespace Altan.Application.Modules
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assemblies = Assembly.GetExecutingAssembly();
            
          
            builder.RegisterAssemblyTypes(assemblies)
                .AssignableTo<ISingleInstance>()
                .AsImplementedInterfaces()
                .SingleInstance();
            
            builder.RegisterAssemblyTypes(assemblies)
                .AssignableTo<IPerRequest>()
                .AsImplementedInterfaces()
                .InstancePerRequest();
            
            builder.RegisterGeneric(typeof(Repository<>))
                .As(typeof(IRepository<>))
                .InstancePerLifetimeScope();
            
            builder.RegisterAssemblyTypes(assemblies)
                .AssignableTo<IPerLifetimeScope>()
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
            
            builder.RegisterAssemblyTypes(assemblies)
                .AssignableTo<IPerDependency>()
                .AsImplementedInterfaces()
                .InstancePerDependency();
        }
    }
}