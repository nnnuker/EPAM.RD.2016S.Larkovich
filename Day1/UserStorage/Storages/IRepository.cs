﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStorage.Entities;

namespace UserStorage.Storages
{
    public interface IRepository
    {
        void Add(IEntity user);
        IEntity Get(Predicate<IEntity> predicate);
        void Delete(int userId);
    }
}
