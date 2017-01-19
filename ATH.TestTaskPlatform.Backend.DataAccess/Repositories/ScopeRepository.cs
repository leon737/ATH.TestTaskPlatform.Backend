using System;
using ATH.TestTaskPlatform.Backend.DataAccess.DataContexts;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using ATH.TestTaskPlatform.Backend.Domain.Repositories;
using Functional.Fluent.Helpers;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.DataAccess.Repositories
{

    /// <summary> The repository for <see cref="Scope"/> </summary>
    public class ScopeRepository : RepositoryBase, IScopeRepository
    {
        /// <summary> The repository for <see cref="Scope"/> </summary>
        public ScopeRepository(DataContext context) : base(context) { }

        /// <summary> Gets <see cref="Scope"/> by identifier </summary>
        public Result<Scope> ById(Guid scopeId) => Result.SuccessIfNotNull(Context.Scopes.Find(scopeId));
    }
}