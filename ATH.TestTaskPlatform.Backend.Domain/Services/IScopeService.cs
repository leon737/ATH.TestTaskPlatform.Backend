using System;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Services
{
    /// <summary> Сервис работы с <see cref="Scope"/> </summary>
    public interface IScopeService
    {
        /// <summary> Возвращает <see cref="Scope"/> по идентификатору </summary>
        Result<Scope> ById(Guid scopeId);
    }
}