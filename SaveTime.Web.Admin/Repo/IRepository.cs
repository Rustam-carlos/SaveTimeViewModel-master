﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTime.Web.Admin.Repo
{
    public interface IRepository<T> where T:class
    {
        void Create(T item);
        IEnumerable<T> GetAll();
        T GetEntity(int id);
        void Delete(T item);
        void Update(T item);
    }
}
