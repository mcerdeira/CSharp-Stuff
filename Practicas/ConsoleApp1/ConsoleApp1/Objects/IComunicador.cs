using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public interface IComunicador
	{
		public int Id { get; set; }

		public void Say(string message);		
	}
}
