using System;
using System.Collections.Generic;
using System.Text;

public struct PersonData
{
	public int Id { get; set; }
	public string Name { get; set; }

	public void Talk(string message)
	{
		Console.WriteLine(message);
	}
}