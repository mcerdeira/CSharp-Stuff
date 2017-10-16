using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public delegate void Del(string message);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Generics
            Generic<string> g = new Generic<string>("hola");
            Generic<int> gint = new Generic<int>(1);

            // Callback using delegate
            ConsoleOutput c = new ConsoleOutput();
            Del handler = c.DelegateMethod;
            Otro o = new Otro();
            o.Metodo("Pirulo", handler);
        }
    }
}
