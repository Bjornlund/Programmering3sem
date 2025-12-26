using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Button : IComponent  //leaf
    {
        private string text;

        public Button(string title) 
        {
            text = title;
        }
        public void Draw()
        {
            Console.WriteLine($"[Buttontext: {text}]");

        }
    }
}
