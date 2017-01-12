using System;
using System.Collections.Generic;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using Functional.Fluent;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Repositories
{
    /// <summary> Репозиторий <see cref="Task"/> </summary>
    public interface ITaskRepository
    {
        /// <summary> Возвращает <see cref="Task"/> по идентификатору </summary>
        Result<Task> ById(Guid taskId);

        /// <summary> Возвращает список <see cref="Task"/> с выборкой по полю Статус /> </summary>
        IReadOnlyList<Task> ByStatus(TaskStatuses status);

        /// <summary> Возвращает список <see cref="Task"/> с выборкой по полю Исполнитель /> </summary>
        IReadOnlyList<Task> ByExecutor(Guid? executorId);

        /// <summary> Удаляет <see cref="Task"/> </summary>
        Result<Unit> Delete(Guid taskId);

        /// <summary> Обновляет <see cref="Task"/> </summary>
        Result<Unit> Update(Task task);

        /// <summary> Создает <see cref="Task"/> </summary>
        Result<Unit> Create(Task task);
    }
}