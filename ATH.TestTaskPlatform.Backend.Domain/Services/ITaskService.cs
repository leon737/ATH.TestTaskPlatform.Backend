using System;
using System.Collections.Generic;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using Functional.Fluent;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Services
{
    /// <summary> Сервис работы с <see cref="Task"/> </summary>
    public interface ITaskService
    {
        /// <summary> Возвращает список <see cref="Task"/> по статусу </summary>
        IReadOnlyList<Task> ByStatus(TaskStatuses taskStatus, Guid scopeId);

        /// <summary> Возвращает список <see cref="Task"/> по исполнителю </summary>
        IReadOnlyList<Task> ByExecutor(Guid? executorId, Guid scopeId);

        /// <summary> Возвращает <see cref="Task"/> по идентификатору </summary>
        Result<Task> ById(Guid taskId, Guid scopeId);

        /// <summary> Удаляет <see cref="Task"/> </summary>
        Result<Unit> Delete(Guid taskId, Guid scopeId);

        /// <summary> Обновляет <see cref="Task"/> </summary>
        Result<Unit> Update(Task task);

        /// <summary> Создает <see cref="Task"/> </summary>
        Result<Unit> Create(Task task);
    }
}