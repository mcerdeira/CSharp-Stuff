using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class Comunicador : IComunicador
	{
		public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void Say(string message)
		{
			Console.WriteLine(String.Format("I'm Comunidador: {0}", message));
		}
	}
}
