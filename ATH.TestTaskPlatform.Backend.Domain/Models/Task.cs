using System;

namespace ATH.TestTaskPlatform.Backend.Domain.Models
{
    /// <summary> Scrum board's task </summary>
    public class Task
    {
        /// <summary> Identifier </summary>
        public Guid Id { get; set; }

        /// <summary> Name </summary>
        public string Name { get; set; }

        /// <summary> Description </summary>
        public string Description { get; set; }

        /// <summary> Workload </summary>
        public int Workload { get; set; }

        /// <summary> Status corresponding <see cref="TaskStatuses"/> </summary>
        public int Status { get; set; }

        /// <summary> Executor identifier </summary>
        public Guid? ExecutorId { get; set; }

        /// <summary> Scope identifier </summary>
        public Guid ScopeId { get; set; }
    }
}
