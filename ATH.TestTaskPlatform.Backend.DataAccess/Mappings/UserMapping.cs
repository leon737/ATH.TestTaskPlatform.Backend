using System.Data.Entity.ModelConfiguration;
using ATH.TestTaskPlatform.Backend.Domain.Models;

namespace ATH.TestTaskPlatform.Backend.DataAccess.Mappings
{
    /// <summary> The mapping for <see cref="User"/> </summary>
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            ToTable(nameof(User));
            HasKey(v => v.Id);
        }
    }
}