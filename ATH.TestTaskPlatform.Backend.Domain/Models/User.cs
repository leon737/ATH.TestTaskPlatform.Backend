using System;

namespace ATH.TestTaskPlatform.Backend.Domain.Models
{

    /// <summary> Пользователь на scrum доске </summary>
    public class User
    {
        /// <summary> Идентификатор </summary>
        public Guid Id { get; set; }
        
        /// <summary> Имя </summary>
        public string Name { get; set; }
        
        /// <summary> Идентификатор scope </summary>
        public Guid ScopeId { get; set; }
    }
}
