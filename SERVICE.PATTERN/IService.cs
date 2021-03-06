﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.PATTERN
{
  public  interface IService<T> where T : class 
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Get(Expression<Func<T, bool>> condition);

        T GetById(int id);
        T GetById(string id);

        void Delete(Expression<Func<T, bool>> condition);

        IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null, Expression<Func<T, bool>> orderBy = null);

        void Commit();
        void Dispose();
    }
}
