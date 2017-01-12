using System;

namespace ATH.TestTaskPlatform.Backend.Domain.Models
{
    public class Scope
    {
        /// <summary> Идентификатор scope </summary>
        public Guid Id { get; set; }   

        /// <summary> Флаг активности </summary>
        public bool Active { get; set; }

        /// <summary> Если не NULL, то минимальная задержка ответа в мс </summary>
        public int? MinDelay { get; set; }

        /// <summary> Если не NULL, то максимальная задержка ответа в мс </summary>
        public int? MaxDelay { get; set; }

        /// <summary> Если не NULL, то вероятность выбрасывания фантомной 500-й ошибки [0 - 1) </summary>
        public double? PhantomError { get; set; }
    }
}