using System;
using System.Collections.Generic;
using System.Linq;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using ATH.TestTaskPlatform.Backend.Domain.Repositories;
using Functional.Fluent.Extensions;

namespace ATH.TestTaskPlatform.Backend.Domain.Services.Impl
{
    /// <summary>
    /// Service for processing objects of type <see cref="User"/>
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary> Returns the list of all executors, <seealso cref="User"/> </summary>
        public IReadOnlyList<User> GetAll(Guid scopeId) => _userRepository.GetAll().Where(x => x.ScopeId == scopeId).AsReadOnlyList();
    }
}