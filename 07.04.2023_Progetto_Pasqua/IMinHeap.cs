using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._04._2023_Progetto_Pasqua
{
    interface IMinHeap<T>
    {
        void Add(T value);
        T RemoveLast();

        bool IsEmpty();
    }
}
