using Functional.Fluent;
using Functional.Fluent.Helpers;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Contexts
{
    public interface ISession
    {
        /// <summary> Saves changes into data storage </summary>
        Result<Unit> SaveChanges();
    }
}