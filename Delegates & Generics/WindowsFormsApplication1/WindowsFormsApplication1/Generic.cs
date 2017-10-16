using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Generic<T>
    {
        private T value;

        public Generic(T value)
        {
            this.value = value;
        }
    }
}
