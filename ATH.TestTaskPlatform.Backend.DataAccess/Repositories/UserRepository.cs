using System;
using System.Collections.Generic;
using ATH.TestTaskPlatform.Backend.DataAccess.DataContexts;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using ATH.TestTaskPlatform.Backend.Domain.Repositories;
using Functional.Fluent.Extensions;
using Functional.Fluent.MonadicTypes;
using Functional.Fluent.Helpers;

namespace ATH.TestTaskPlatform.Backend.DataAccess.Repositories
{
    /// <summary> The repository <see cref="User"/> </summary>
    public class UserRepository : RepositoryBase, IUserRepository
    {
        /// <summary> The repository <see cref="User"/> </summary>
        public UserRepository(DataContext context) : base(context) { }

        /// <summary> Gets <see cref="User"/> by identitifer </summary>
        public Result<User> ById(Guid userId) => Result.SuccessIfNotNull(Context.Users.Find(userId));

        /// <summary> Returns the list of <see cref="User"/> </summary>
        public IReadOnlyList<User> GetAll() => Context.Users.AsReadOnlyList();
    }
}