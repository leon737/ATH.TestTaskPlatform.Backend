using System;
using System.Collections.Generic;
using System.Web.Http;
using ATH.TestTaskPlatform.Backend.Domain.Services;
using ATH.TestTaskPlatform.Backend.Filters;
using AutoMapper;
using User = ATH.TestTaskPlatform.Backend.Models.User;

namespace ATH.TestTaskPlatform.Backend.Controllers
{
    [ScopeFilter]
    [RoutePrefix("users")]
    public class UsersController : ApiController
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("get/{scopeId}")]
        public IEnumerable<User> Get(Guid scopeId)
        {
            return _mapper.Map<IEnumerable<Domain.Models.User>, IEnumerable<User>>(_userService.GetAll(scopeId));
        }
    }
}
