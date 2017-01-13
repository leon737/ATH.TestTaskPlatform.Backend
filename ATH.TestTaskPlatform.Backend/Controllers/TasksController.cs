using System;
using System.Collections.Generic;
using System.Web.Http;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using ATH.TestTaskPlatform.Backend.Domain.Services;
using ATH.TestTaskPlatform.Backend.Filters;
using AutoMapper;
using Functional.Fluent.Extensions;
using Task = ATH.TestTaskPlatform.Backend.Models.Task;

namespace ATH.TestTaskPlatform.Backend.Controllers
{
    [ScopeFilter]
    [RoutePrefix("tasks")]
    public class TasksController : ApiController
    {
        private readonly ITaskService _taskService;
        private readonly IMapper _mapper;

        public TasksController(ITaskService taskService, IMapper mapper)
        {
            _taskService = taskService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("get/{scopeId}/{taskId}")]
        public Task GetById(Guid scopeId, Guid taskId)
        {
            return _mapper.Map<Domain.Models.Task, Task>(_taskService.ById(taskId, scopeId).Fail(() =>
            {
                throw new ArgumentException("Invalid task identifier");
            }));
        }

        [HttpGet]
        [Route("bystatus/{scopeId}/{status}")]
        public IEnumerable<Task> GetByStatus(Guid scopeId, TaskStatuses status)
        {
            return _mapper.Map<IEnumerable<Domain.Models.Task>, IEnumerable<Task>>(_taskService.ByStatus(status, scopeId));
        }

        [HttpGet]
        [Route("byexecutor/{scopeId}/{executorId}")]
        public IEnumerable<Task> GetByExecutor(Guid scopeId, Guid? executorId)
        {
            return _mapper.Map<IEnumerable<Domain.Models.Task>, IEnumerable<Task>>(_taskService.ByExecutor(executorId, scopeId));
        }

        //// POST api/tasks
        [HttpPost]
        [Route("{scopeId}")]
        public void Post(Guid scopeId, [FromBody]Task value)
        {
            var domain = _mapper.Map<Task, Domain.Models.Task>(value);
            domain.ScopeId = scopeId;
            var result = _taskService.Update(domain);
            if (result.IsFailed)
                throw new AccessViolationException();
        }

        ///PUT api/tasks
        public void Put(Guid scopeId, [FromBody]Task value)
        {
            var domain = _mapper.Map<Task, Domain.Models.Task>(value);
            domain.ScopeId = scopeId;
            _taskService.Create(domain);
        }

        /// DELETE api/users/5
        [Route("{scopeId}/{taskId}")]
        public void Delete(Guid scopeId, Guid taskId)
        {
            var result = _taskService.Delete(taskId, scopeId);
            if (result.IsFailed)
                throw new AccessViolationException();
        }
    }
}
