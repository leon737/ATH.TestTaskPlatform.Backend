using ATH.TestTaskPlatform.Backend.Domain.Models;
using AutoMapper;

namespace ATH.TestTaskPlatform.Backend
{
    public class WebApiAutomapperProfile : Profile
    {
        public WebApiAutomapperProfile()
        {
            CreateMap<User, Models.User>();
            CreateMap<Models.User, User>();
            CreateMap<Task, Task>();
            CreateMap<Task, Models.Task>();
            CreateMap<Models.Task, Task>();
        }
    }
}