using System;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Repositories
{
    /// <summary> Репозиторий <see cref="Scope"/> </summary>
    public interface IScopeRepository
    {
        /// <summary> Возвращает <see cref="Scope"/> по идентификатору </summary>
        Result<Scope> ById(Guid scopeId);
    }
}