using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IOrderRepository
    {

    }
    public class OrderRepository : RepositoryBase<IOrderRepository>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
