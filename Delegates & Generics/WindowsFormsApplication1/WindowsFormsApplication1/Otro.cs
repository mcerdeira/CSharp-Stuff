using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Otro
    {
        public void Metodo(string mensaje, WindowsFormsApplication1.Form1.Del callback)
        {
            callback(mensaje);
        }
    }
}
