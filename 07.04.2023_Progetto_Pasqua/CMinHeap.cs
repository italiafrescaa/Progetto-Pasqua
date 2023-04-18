using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._04._2023_Progetto_Pasqua
{
    class CMinHeap<T>: IMinHeap<T>
    {
        public CNode<T> Root { get; private set; }
        public int Count { get; private set; }

        public CMinHeap()
        {
            Root = null;
            Count = 0;
        }

        public void Add(T value)
        {
            CNode<T> node = new CNode<T>(value);

            if (Root == null)
            {
                Root = node;
                Count++;

                return;
            }
            CNode<T> temp;
            Queue<CNode<T>> queue = new Queue<CNode<T>>();

            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                temp = queue.Dequeue();
                if (temp.Left == null)
                {
                    temp.Left = temp;
                    node.Prec = temp;

                    break;
                }
                else if (temp.Right == null)
                {
                    temp.Right = node;
                    node.Prec = temp;

                    break;
                }
                else
                {
                    queue.Enqueue(temp.Left);
                    queue.Enqueue(temp.Right);
                }
            }
            Heapify(node);
            Count++;
        }

        private void Heapify(CNode<T> node)
        {
            while (node.Prec != null && node.CompareTo(node.Prec) < 0)
            {
                SwapValues(node, node.Prec);
                node = node.Prec;
            }
        }

        private void SwapValues(CNode<T> node1, CNode<T> node2)
        {
            T temp = node1.Value;
            node1.Value = node2.Value;
            node2.Value = temp;
        }

        public T RemoveLast()
        {
            if (Root == null)
            {
                return default;
            }
            CNode<T> temp = Root;

            while (temp.Right != null)
            {
                temp = temp.Right;
            }

            if (temp.Left != null)
            {
                temp = temp.Left;
            }

            if (temp.Prec != null)
            {
                if (temp.Prec.Right == null)
                {
                    temp.Prec.Left = null;
                }
                else
                {
                    temp.Prec.Right = null;
                }
            }
            Count--;
            return temp.Value;
        }

        public bool IsEmpty()
        {
            return Root == null;
        }
    }
}
