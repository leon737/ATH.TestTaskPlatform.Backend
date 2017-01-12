using System;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using ATH.TestTaskPlatform.Backend.Domain.Repositories;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Services.Impl
{
    public class ScopeService : IScopeService
    {
        private readonly IScopeRepository _scopeRepository;

        public ScopeService(IScopeRepository scopeRepository)
        {
            _scopeRepository = scopeRepository;
        }
        
        /// <summary> Возвращает <see cref="Scope"/> по идентификатору </summary>
        public Result<Scope> ById(Guid scopeId) => _scopeRepository.ById(scopeId);
    }
}