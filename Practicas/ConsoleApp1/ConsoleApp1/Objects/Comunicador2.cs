using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class Comunicador2 : AComunicador
	{
		public override void Say(string message)
		{
			Console.WriteLine(String.Format("Comunicador 2: {0}", message));
		}
	}
}
