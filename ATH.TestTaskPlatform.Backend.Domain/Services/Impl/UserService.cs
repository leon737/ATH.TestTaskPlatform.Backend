using System;
using System.Collections.Generic;
using System.Linq;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using ATH.TestTaskPlatform.Backend.Domain.Repositories;
using Functional.Fluent.Extensions;

namespace ATH.TestTaskPlatform.Backend.Domain.Services.Impl
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary> Возвращает список всех исполнителей </summary>
        public IReadOnlyList<User> GetAll(Guid scopeId) => _userRepository.GetAll().Where(x => x.ScopeId == scopeId).AsReadOnlyList();
    }
}