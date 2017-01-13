using ATH.TestTaskPlatform.Backend.DataAccess.DataContexts;
using ATH.TestTaskPlatform.Backend.DataAccess.Repositories;
using ATH.TestTaskPlatform.Backend.Domain.Contexts;
using ATH.TestTaskPlatform.Backend.Domain.Repositories;
using ATH.TestTaskPlatform.Backend.Domain.Services;
using ATH.TestTaskPlatform.Backend.Domain.Services.Impl;
using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;

namespace ATH.TestTaskPlatform.Backend.App_Start
{
    public class WebApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DataContext>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<Session>().As<ISession>().InstancePerLifetimeScope();

            builder.RegisterType<ScopeRepository>().As<IScopeRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            builder.RegisterType<TaskRepository>().As<ITaskRepository>().InstancePerLifetimeScope();

            builder.RegisterType<ScopeService>().As<IScopeService>();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<TaskService>().As<ITaskService>();

            builder.RegisterType<WebApiAutomapperProfile>().As<Profile>();

            builder.Register(c =>
            {
                var profiles = c.Resolve<Profile[]>();

                return new MapperConfiguration(cfg =>
                {
                    foreach (var profile in profiles)
                    {
                        cfg.AddProfile(profile);
                    }
                });
            }).AsSelf();

            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>();
        }
    }
}