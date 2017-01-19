using System;
using System.Collections.Generic;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using Functional.Fluent;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Repositories
{
    /// <summary> The repository for <see cref="Task"/> </summary>
    public interface ITaskRepository
    {
        /// <summary> Gets <see cref="Task"/> by identifier </summary>
        Result<Task> ById(Guid taskId);

        /// <summary> Returns the list of <see cref="Task"/> filtered by status </summary>
        IReadOnlyList<Task> ByStatus(TaskStatuses status);

        /// <summary> Returns the list <see cref="Task"/> filtered by executor </summary>
        IReadOnlyList<Task> ByExecutor(Guid? executorId);

        /// <summary> Deletes <see cref="Task"/> </summary>
        Result<Unit> Delete(Guid taskId);

        /// <summary> Updates <see cref="Task"/> </summary>
        Result<Unit> Update(Task task);

        /// <summary> Creates new <see cref="Task"/> </summary>
        Result<Unit> Create(Task task);
    }
}