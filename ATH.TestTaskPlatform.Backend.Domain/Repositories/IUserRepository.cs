using System;
using System.Collections.Generic;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Repositories
{

    /// <summary> The repository <see cref="User"/> </summary>
    public interface IUserRepository
    {

        /// <summary> Gets <see cref="User"/> by identitifer </summary>
        Result<User> ById(Guid userId);

        /// <summary> Returns the list of <see cref="User"/> </summary>
        IReadOnlyList<User> GetAll();
    }
}