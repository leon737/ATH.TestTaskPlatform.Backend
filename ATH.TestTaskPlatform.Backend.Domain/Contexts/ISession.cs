using Functional.Fluent;
using Functional.Fluent.Helpers;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Contexts
{
    public interface ISession
    {
        /// <summary> Сохраняет изменения в хранилище данных </summary>
        Result<Unit> SaveChanges();
    }
}