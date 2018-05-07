using Data.Infrastructure;
using Model.Model;

namespace Data.Repositories
{
    public interface IErrorRepository
    {
        Error Add(Error error);
    }
    public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}