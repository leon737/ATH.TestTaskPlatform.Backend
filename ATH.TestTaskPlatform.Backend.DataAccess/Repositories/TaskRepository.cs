using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ATH.TestTaskPlatform.Backend.DataAccess.DataContexts;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using ATH.TestTaskPlatform.Backend.Domain.Repositories;
using AutoMapper;
using Functional.Fluent;
using Functional.Fluent.Extensions;
using Functional.Fluent.MonadicTypes;
using Functional.Fluent.Helpers;

namespace ATH.TestTaskPlatform.Backend.DataAccess.Repositories
{
    /// <summary> The repository for <see cref="Task"/> </summary>
    public class TaskRepository : RepositoryBase, ITaskRepository
    {

        private readonly IMapper _mapper;

        /// <summary> The repository for <see cref="Task"/> </summary>
        public TaskRepository(DataContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        /// <summary> Gets <see cref="Task"/> by identifier </summary>
        public Result<Task> ById(Guid taskId) => Result.SuccessIfNotNull(Context.Tasks.Find(taskId));

        /// <summary> Returns the list of <see cref="Task"/> filtered by status </summary>
        public IReadOnlyList<Task> ByStatus(TaskStatuses status) => Context.Tasks.Where(x => x.Status == (int)status).AsReadOnlyList();

        /// <summary> Returns the list <see cref="Task"/> filtered by executor </summary>
        public IReadOnlyList<Task> ByExecutor(Guid? executorId) => Context.Tasks.Where(x => x.ExecutorId == executorId).AsReadOnlyList();

        /// <summary> Deletes <see cref="Task"/> </summary>
        public Result<Unit> Delete(Guid taskId) => ById(taskId).Success(t =>
        {
            Context.Tasks.Remove(t);
            return Result.Success();
        });

        /// <summary> Updates <see cref="Task"/> </summary>
        public Result<Unit> Update(Task task) => ById(task.Id).Success(t =>
        {
            _mapper.Map(task, t);
            return Result.Success();
        });

        /// <summary> Creates new <see cref="Task"/> </summary>
        public Result<Unit> Create(Task task)
        {
            Context.Tasks.Add(task);
            return Result.Success();
        }
    }
}