using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.BookApp.DataAccess
{
    public interface IRepository<T>
    {
        T GetById(int id);

        List<T> GetAll(int id);

        int Insert(T entity);

        void Update(T entity);

        void DeleteById(int id);
    }
}
