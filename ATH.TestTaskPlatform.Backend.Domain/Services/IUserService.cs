using System;
using System.Collections.Generic;
using ATH.TestTaskPlatform.Backend.Domain.Models;

namespace ATH.TestTaskPlatform.Backend.Domain.Services
{
    /// <summary> Service for processing objects of type <see cref="User"/> </summary>
    public interface IUserService
    {
        /// <summary> Returns the list of all executors, <seealso cref="User"/> </summary>
        IReadOnlyList<User> GetAll(Guid scopeId);
    }
}