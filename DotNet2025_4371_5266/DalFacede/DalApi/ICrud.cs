﻿using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface ICrud<T> 
    {
        int Create(T item);
        T? Read(int Id);
        List<T?> ReadAll();
        void Update(T item);
        void Delete(int id);
    }
}

