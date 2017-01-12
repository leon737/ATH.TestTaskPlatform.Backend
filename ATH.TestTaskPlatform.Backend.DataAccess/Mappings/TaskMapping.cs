using System.Data.Entity.ModelConfiguration;
using ATH.TestTaskPlatform.Backend.Domain.Models;

namespace ATH.TestTaskPlatform.Backend.DataAccess.Mappings
{
    /// <summary> Маппинг для <see cref="Task"/> </summary>
    public class TaskMapping : EntityTypeConfiguration<Task>
    {
        public TaskMapping()
        {
            ToTable(nameof(Task));
            HasKey(v => v.Id);
        }
    }
}