using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Persona
    {
        internal string Name;

        public virtual void Hola()
        {

        }

        public Persona()
        {
            Name = "Pipi";
        }

        public void SayName()
        {
            Console.WriteLine(Name);
        }
    }
}
