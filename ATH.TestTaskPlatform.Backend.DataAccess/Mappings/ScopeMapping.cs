using System.Data.Entity.ModelConfiguration;
using ATH.TestTaskPlatform.Backend.Domain.Models;

namespace ATH.TestTaskPlatform.Backend.DataAccess.Mappings
{
    /// <summary> The mapping for <see cref="Scope"/> </summary>
    public class ScopeMapping : EntityTypeConfiguration<Scope>
    {
        public ScopeMapping()
        {
            ToTable(nameof(Scope));
            HasKey(v => v.Id);
        }
    }
}