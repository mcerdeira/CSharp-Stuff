using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public abstract class Shape
    {
        internal string Tipo;

        public void Metodo()
        {
            Tipo = "";
        }

        public abstract void Area();
    }
}
