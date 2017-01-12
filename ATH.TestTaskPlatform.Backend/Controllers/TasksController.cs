using System;
using System.Collections.Generic;
using System.Web.Http;
using ATH.TestTaskPlatform.Backend.Domain.Models;
using ATH.TestTaskPlatform.Backend.Domain.Services;

namespace ATH.TestTaskPlatform.Backend.Controllers
{
    [RoutePrefix("tasks")]
    public class TasksController : ApiController
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        [Route("get/{scopeId}/{taskId}")]
        public Task GetByStatus(Guid scopeId, Guid taskId)
        {
            return _taskService.ById(taskId, scopeId);
        }

        [HttpGet]
        [Route("bystatus/{scopeId}/{status}")]
        public IEnumerable<Task> GetByStatus(Guid scopeId, TaskStatuses status)
        {
            return _taskService.ByStatus(status, scopeId);
        }

        [HttpGet]
        [Route("byexecutor/{scopeId}/{executorId}")]
        public IEnumerable<Task> GetByExecutor(Guid scopeId, Guid? executorId)
        {
            return _taskService.ByExecutor(executorId, scopeId);
        }

        //// POST api/tasks
        public void Post([FromBody]Task value)
        {
            var result = _taskService.Update(value);
            if (result.IsFailed)
                throw new AccessViolationException();
        }
        
        ///PUT api/tasks
        public void Put([FromBody]Task value)
        {
            _taskService.Create(value);
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
