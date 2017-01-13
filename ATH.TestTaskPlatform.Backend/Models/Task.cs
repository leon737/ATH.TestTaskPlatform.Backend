using System;
using ATH.TestTaskPlatform.Backend.Domain.Models;

namespace ATH.TestTaskPlatform.Backend.Models
{
    /// <summary> Задача на scrum доске </summary>
    public class Task
    {
        /// <summary> Идентификатор </summary>
        public Guid Id { get; set; }

        /// <summary> Наименование </summary>
        public string Name { get; set; }

        /// <summary> Описание задачи </summary>
        public string Description { get; set; }

        /// <summary> Трудозатраты </summary>
        public int Workload { get; set; }

        /// <summary> Статус <see cref="TaskStatuses"/> </summary>
        public int Status { get; set; }

        /// <summary> Идентификатор исполнителя </summary>
        public Guid? ExecutorId { get; set; }
    }
}
