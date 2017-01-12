using System;
using System.Collections.Generic;
using System.Web.Http;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using ATH.TestTaskPlatform.Backend.Domain.Services;

namespace ATH.TestTaskPlatform.Backend.Controllers
{
    [RoutePrefix("users")]
    public class UsersController : ApiController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("get/{scopeId}")]
        public IEnumerable<User> Get(Guid scopeId)
        {
            return _userService.GetAll(scopeId);
        }
    }
}
