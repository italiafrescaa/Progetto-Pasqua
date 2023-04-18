using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._04._2023_Progetto_Pasqua
{
    class CTecla
    {
        bool end;
        CSharedTree sharedtree;

        public CTecla(CSharedTree sharedtree)
        {
            end = false;
            this.sharedtree = sharedtree;
        }

        public void Start()
        {
            Random seed = new Random();
            Random rnd = new Random(seed.Next(1, 1000));

            while (!end)
            {
                Thread.Sleep(rnd.Next(500, 2000));
                sharedtree.ScareBird();
            }
        }

        public void End()
        {
            end = true;
        }
    }
}
