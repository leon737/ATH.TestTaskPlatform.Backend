using System;
using System.Collections.Generic;
using ATH.TestTaskPlatform.Backend.Domain.Models;

namespace ATH.TestTaskPlatform.Backend.Domain.Services
{
    /// <summary> Сервис работы с <see cref="User"/> </summary>
    public interface IUserService
    {
        /// <summary> Возвращает список всех исполнителей </summary>
        IReadOnlyList<User> GetAll(Guid scopeId);
    }
}