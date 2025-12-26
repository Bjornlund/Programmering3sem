using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Panel : IComponent //Composite
    {

        //Liste af leafs?
        private readonly List<IComponent> components = new List<IComponent>();

        public void Add(IComponent component)
        { 
            components.Add(component);
        }

        public void Remove(IComponent component) 
        {
            components.Remove(component);
        }

        public void GetComponent()
        { }

        public void Draw()
        {
            Console.WriteLine("- Panel Start -\n");

            foreach (IComponent component in components)
            {
                component.Draw();
            }

            Console.WriteLine("\n- Panel End -");

        }
    }
}
