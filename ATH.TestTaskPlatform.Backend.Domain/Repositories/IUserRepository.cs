using System;
using System.Collections.Generic;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Repositories
{

    /// <summary> Репозиторий <see cref="User"/> </summary>
    public interface IUserRepository
    {
        
        /// <summary> Возвращает <see cref="User"/> по идентификатору </summary>
        Result<User> ById(Guid userId);

        /// <summary> Возвращает список <see cref="User"/> </summary>
        IReadOnlyList<User> GetAll();
    }
}