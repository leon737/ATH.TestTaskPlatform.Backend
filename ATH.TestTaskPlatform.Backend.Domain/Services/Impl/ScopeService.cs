using System;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using ATH.TestTaskPlatform.Backend.Domain.Repositories;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Services.Impl
{

    /// <summary>
    /// Service for processing objects of type <see cref="Scope"/>
    /// </summary>
    public class ScopeService : IScopeService
    {
        private readonly IScopeRepository _scopeRepository;

        public ScopeService(IScopeRepository scopeRepository)
        {
            _scopeRepository = scopeRepository;
        }
        
        /// <summary> Gets <see cref="Scope"/> by identifier </summary>
        public Result<Scope> ById(Guid scopeId) => _scopeRepository.ById(scopeId);
    }
}