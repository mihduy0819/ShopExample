using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Data.Infrastructure
{
    //Day la lop genneric co the dung cho cac lop trong du an
    public interface IRepository<T> where T : class
    {
        //Phuong thuc tao moi mot thuoc tinh
        T Add(T entity);

        //Phuong thuc thay doi thuoc tinh
        void Update(T entity);

        //Xoa 1 thuoc tinh
        T Delete(T entity);
        T Delete(int id);
        //Xoa nhieu thuoc tinh
        void DeleteMulti(Expression<Func<T, bool>> where);

        //Lay gia tri id voi kieu int
        T GetSingleById(int id);

        //Lay du lieu tu condition
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IEnumerable<T> GetAll(string[] includes = null);

        IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int intdex = 0, int size = 0, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}