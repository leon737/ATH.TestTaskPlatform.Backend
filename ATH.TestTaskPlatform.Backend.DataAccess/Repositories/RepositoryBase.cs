using ATH.TestTaskPlatform.Backend.DataAccess.DataContexts;

namespace ATH.TestTaskPlatform.Backend.DataAccess.Repositories
{
    public abstract class RepositoryBase
    {
        protected DataContext Context { get; }

        protected RepositoryBase(DataContext context)
        {
            Context = context;
        }
    }
}