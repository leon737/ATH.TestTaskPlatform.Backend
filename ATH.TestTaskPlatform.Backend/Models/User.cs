using System;

namespace ATH.TestTaskPlatform.Backend.Models
{

    /// <summary> Пользователь на scrum доске </summary>
    public class User
    {
        /// <summary> Идентификатор </summary>
        public Guid Id { get; set; }
        
        /// <summary> Имя </summary>
        public string Name { get; set; }
        
    }
}
