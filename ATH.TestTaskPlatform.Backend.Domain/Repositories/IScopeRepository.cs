using System;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Repositories
{
    /// <summary> The repository for <see cref="Scope"/> </summary>
    public interface IScopeRepository
    {
        /// <summary> Gets <see cref="Scope"/> by identifier </summary>
        Result<Scope> ById(Guid scopeId);
    }
}