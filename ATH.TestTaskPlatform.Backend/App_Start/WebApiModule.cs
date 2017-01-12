using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ATH.TestTaskPlatform.Backend.DataAccess.DataContexts;
using ATH.TestTaskPlatform.Backend.DataAccess.Repositories;
using ATH.TestTaskPlatform.Backend.Domain.Repositories;
using ATH.TestTaskPlatform.Backend.Domain.Services;
using ATH.TestTaskPlatform.Backend.Domain.Services.Impl;
using Autofac;

namespace ATH.TestTaskPlatform.Backend.App_Start
{
    public class WebApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DataContext>().AsSelf();

            builder.RegisterType<ScopeRepository>().As<IScopeRepository>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<TaskRepository>().As<ITaskRepository>();

            builder.RegisterType<ScopeService>().As<IScopeService>();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<TaskService>().As<ITaskService>();
        }
    }
}