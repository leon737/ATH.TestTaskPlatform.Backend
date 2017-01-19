using System;

namespace ATH.TestTaskPlatform.Backend.Models
{

    /// <summary> Scrum board's user </summary>
    public class User
    {
        /// <summary> Identifier of the user </summary>
        public Guid Id { get; set; }
        
        /// <summary> Full name of the user </summary>
        public string Name { get; set; }
        
    }
}
