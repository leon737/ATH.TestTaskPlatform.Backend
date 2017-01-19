using System;
using System.Collections.Generic;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using Functional.Fluent;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Services
{
    /// <summary>Service for processing objects of type  <see cref="Task"/> </summary>
    public interface ITaskService
    {
        /// <summary> Returns the list of <see cref="Task"/> filtered by status </summary>
        IReadOnlyList<Task> ByStatus(TaskStatuses taskStatus, Guid scopeId);

        /// <summary> Returns the list of <see cref="Task"/> filtered by executor </summary>
        IReadOnlyList<Task> ByExecutor(Guid? executorId, Guid scopeId);

        /// <summary> Gets <see cref="Task"/> by identifier </summary>
        Result<Task> ById(Guid taskId, Guid scopeId);

        /// <summary> Deletes <see cref="Task"/> </summary>
        Result<Unit> Delete(Guid taskId, Guid scopeId);

        /// <summary> Updates <see cref="Task"/> </summary>
        Result<Unit> Update(Task task);

        /// <summary> Creates new <see cref="Task"/> </summary>
        Result<Unit> Create(Task task);
    }
}