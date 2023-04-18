using System;
using System.Collections.Generic;

namespace _07._04._2023_Progetto_Pasqua
{
    public class CNode<T>
    {
        public T Value { get; set; }

        public CNode<T> Prec { get; set; }

        public CNode<T> Left { get; set; }
        public CNode<T> Right { get; set; }

        public CNode(T value)
        {
            Value = value;

            Prec = null;

            Left = null;
            Right = null;
        }

        public int CompareTo(CNode<T> node)
        {
            if (node != null)
                return Comparer<T>.Default.Compare(Value, node.Value);
            return -2;
        }
    }
}

