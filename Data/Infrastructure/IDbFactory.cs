using System;

namespace Data.Infrastructure
{
    public interface IDbFactory:IDisposable
    {
        ShopExampleDbContext Init();
    }
}