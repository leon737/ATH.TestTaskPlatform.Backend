using System;
using ATH.TestTaskPlatform.Backend.Domain.Models;

namespace ATH.TestTaskPlatform.Backend.Models
{
    /// <summary> Scrum board's task </summary>
    public class Task
    {
        /// <summary> Identifier of the task </summary>
        public Guid Id { get; set; }

        /// <summary> Name of the task </summary>
        public string Name { get; set; }

        /// <summary> Description of the task </summary>
        public string Description { get; set; }

        /// <summary> Expected worload </summary>
        public int Workload { get; set; }

        /// <summary> Status of the task, <see cref="TaskStatuses"/> </summary>
        public int Status { get; set; }

        /// <summary> Identifier of the task's executor </summary>
        public Guid? ExecutorId { get; set; }
    }
}
