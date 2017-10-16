using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Estudiante : Persona
    {
        public Estudiante()
        {
            Name = "";
        }

        public override void Hola()
        {
            
        }

        public void SayName()
        {
            base.SayName();
        }
    }
}
