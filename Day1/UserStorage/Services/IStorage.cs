﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStorage.Entities;

namespace UserStorage.Services
{
    public interface IStorage<T> where T : IEntity
    {
        int Add(T entity);

        T Search(int id);

        bool Delete(int entityId);

        void Save();
    }
}
