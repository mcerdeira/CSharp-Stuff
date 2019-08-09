using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public abstract class AComunicador
	{
		public int Id { get; set; }
		public virtual void Say(string message)
		{
			Console.WriteLine(message);
		}

		public void Bye()
		{
			Console.WriteLine("Bye");
		}
	}
}
