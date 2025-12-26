using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Label : IComponent //Leaf
    {

        private string text;

        public Label(string title)
        {
            text = title;
        }
        public void Draw()
        {
            Console.WriteLine($"[Labeltext: {text}]");

        }
    }
}
