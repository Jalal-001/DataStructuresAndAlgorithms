﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue.Contract
{
    public interface IQueue<T>:IEnumerable<T>
    {
        int Count { get; }
        void EnQueue(T item);
        T DeQueue();
        T Peek();
    }
}
