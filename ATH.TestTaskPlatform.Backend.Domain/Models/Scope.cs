using System;

namespace ATH.TestTaskPlatform.Backend.Domain.Models
{
    public class Scope
    {
        /// <summary> Identifier </summary>
        public Guid Id { get; set; }   

        /// <summary> Activity flag </summary>
        public bool Active { get; set; }

        /// <summary> Minumum delay in ms, if not null </summary>
        public int? MinDelay { get; set; }

        /// <summary> Maximum delay in ms, if not null </summary>
        public int? MaxDelay { get; set; }

        /// <summary> THe probability of phantom error to be thrown [0-1), if not null </summary>
        public double? PhantomError { get; set; }
    }
}