using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._04._2023_Progetto_Pasqua
{
    class CSharedTree
    {
        CMinHeap<CBird> tree;

        static readonly object locker = new object();
        public event EventHandler<TextEventArgs> write;

        public CSharedTree()
        {
            tree = new CMinHeap<CBird>();
        }

        public void AddBird(CBird bird)
        {
            lock (locker)
            {
                OnWrite(new TextEventArgs($"Anselmo announces bird {bird.Number} that weighs {bird.Weight}", "DarkYellow"));
                tree.Add(bird);

                Monitor.Pulse(locker);
            }
        }

        public void ScareBird()
        {
            lock (locker)
            {
                if(tree.IsEmpty())
                {
                    OnWrite(new TextEventArgs("The tree is empty and Tecla sleeps", "Blue"));
                    Monitor.Wait(locker);
                }
                CBird bird = tree.RemoveLast();
                OnWrite(new TextEventArgs($"Tecla has removed the bird {bird.Number} that weighs {bird.Weight}", "Blue"));

                Monitor.Pulse(locker);
            }
        }

        protected virtual void OnWrite(TextEventArgs e)
        {
            EventHandler<TextEventArgs> handler = write;
            handler?.Invoke(this, e);
        }
    }
}
