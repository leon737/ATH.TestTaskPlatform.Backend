using System;

namespace ATH.TestTaskPlatform.Backend.Domain.Models
{

    /// <summary> Scrum board's user </summary>
    public class User
    {
        /// <summary> Identifier </summary>
        public Guid Id { get; set; }
        
        /// <summary> Name </summary>
        public string Name { get; set; }
        
        /// <summary> Scope identifier </summary>
        public Guid ScopeId { get; set; }
    }
}
