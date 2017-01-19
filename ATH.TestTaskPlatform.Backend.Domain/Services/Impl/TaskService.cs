using System;
using System.Collections.Generic;
using System.Linq;
using ATH.TestTaskPlatform.Backend.Domain.Contexts;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using ATH.TestTaskPlatform.Backend.Domain.Repositories;
using Functional.Fluent;
using Functional.Fluent.Extensions;
using Functional.Fluent.Helpers;
using Functional.Fluent.MonadicTypes;

namespace ATH.TestTaskPlatform.Backend.Domain.Services.Impl
{
    /// <summary>
    /// Service for processing objects of type <see cref="Task"/>
    /// </summary>
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ISession _session;

        public TaskService(ITaskRepository taskRepository, ISession session)
        {
            _taskRepository = taskRepository;
            _session = session;
        }

        /// <summary> Returns the list of <see cref="Task"/> filtered by status </summary>
        public IReadOnlyList<Task> ByStatus(TaskStatuses taskStatus, Guid scopeId) => FilterByScope(scopeId, () => _taskRepository.ByStatus(taskStatus));

        /// <summary> Returns the list of <see cref="Task"/> filtered by executor </summary>
        public IReadOnlyList<Task> ByExecutor(Guid? executorId, Guid scopeId) => FilterByScope(scopeId, () => _taskRepository.ByExecutor(executorId));

        private IReadOnlyList<Task> FilterByScope(Guid scopeId, Func<IReadOnlyList<Task>> func) => func().Where(x => x.ScopeId == scopeId).AsReadOnlyList();

        /// <summary> Gets <see cref="Task"/> by identifier </summary>
        public Result<Task> ById(Guid taskId, Guid scopeId) => _taskRepository.ById(taskId).Success(t => t.ScopeId == scopeId ? Result.Success(t) : Result.Fail<Task>());

        /// <summary> Deletes <see cref="Task"/> </summary>
        public Result<Unit> Delete(Guid taskId, Guid scopeId) => _taskRepository.ById(taskId).Success(t =>
            t.Match()
                .With(x => x.ScopeId == scopeId, _taskRepository.Delete(t.Id))
                .Else(Result.Fail<Unit>())
                .Do()
                .PureSuccess(_session.SaveChanges())
            );

        /// <summary> Updates <see cref="Task"/> </summary>
        public Result<Unit> Update(Task task) => _taskRepository.ById(task.Id).Success(t =>
            t.Match()
                .With(x => x.ScopeId == task.ScopeId, _taskRepository.Update(task))
                .Else(Result.Fail<Unit>())
                .Do()
                .PureSuccess(_session.SaveChanges())
            );

        /// <summary> Creates new <see cref="Task"/> </summary>
        public Result<Unit> Create(Task task) => _taskRepository.Create(task).PureSuccess(_session.SaveChanges());
    }
}