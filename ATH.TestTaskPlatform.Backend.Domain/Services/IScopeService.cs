using System;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Services
{
    /// <summary> Service for processing objects of type <see cref="Scope"/> </summary>
    public interface IScopeService
    {
        /// <summary> Gets <see cref="Scope"/> by identifier </summary>
        Result<Scope> ById(Guid scopeId);
    }
}