using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._04._2023_Progetto_Pasqua
{
    class TextEventArgs: EventArgs
    {
        public string Text { get; }
        public string Color { get; }

        public TextEventArgs(string text, string color)
        {
            Text = text;
            Color = color;
        }
    }
}
