using System;
using System.Collections.Generic;
using System.Linq;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using ATH.TestTaskPlatform.Backend.Domain.Repositories;
using Functional.Fluent;
using Functional.Fluent.Extensions;
using Functional.Fluent.Helpers;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Services.Impl
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        /// <summary> Возвращает список <see cref="Task"/> по статусу </summary>
        public IReadOnlyList<Task> ByStatus(TaskStatuses taskStatus, Guid scopeId) => FilterByScope(scopeId, () => _taskRepository.ByStatus(taskStatus));

        /// <summary> Возвращает список <see cref="Task"/> по исполнителю </summary>
        public IReadOnlyList<Task> ByExecutor(Guid? executorId, Guid scopeId) => FilterByScope(scopeId, () => _taskRepository.ByExecutor(executorId));

        private IReadOnlyList<Task> FilterByScope(Guid scopeId, Func<IReadOnlyList<Task>> func) => func().Where(x => x.ScopeId == scopeId).AsReadOnlyList();

        /// <summary> Возвращает <see cref="Task"/> по идентификатору </summary>
        public Result<Task> ById(Guid taskId, Guid scopeId) => _taskRepository.ById(taskId).Success(t => t.ScopeId == scopeId ? Result.Success(t) : Result.Fail<Task>());

        /// <summary> Удаляет <see cref="Task"/> </summary>
        public Result<Unit> Delete(Guid taskId, Guid scopeId) => _taskRepository.ById(taskId).Success(t => t.ScopeId == scopeId ? _taskRepository.Delete(t.Id) : Result.Fail<Unit>());

        /// <summary> Обновляет <see cref="Task"/> </summary>
        public Result<Unit> Update(Task task) =>_taskRepository.ById(task.Id).Success(t => t.ScopeId == task.ScopeId? _taskRepository.Update(t) : Result.Fail<Unit>());

        /// <summary> Создает <see cref="Task"/> </summary>
        public Result<Unit> Create(Task task) => _taskRepository.Create(task);
    }
}