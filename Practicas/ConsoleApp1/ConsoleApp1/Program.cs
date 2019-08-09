using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			// using scope
			using (NormClass normClass = new NormClass())
			{
				normClass.Id = 0;
				normClass.Description = "Algo";
			}

			// interface parameter passing
			Comunicador comunicador = new Comunicador();
			MakeTalk(comunicador);

			// abstract class, using overriden and not overriden method
			Comunicador2 comunicador2 = new Comunicador2();
			comunicador2.Say("Hello");
			comunicador2.Bye();

			// Struct
			PersonData personData = new PersonData();
			personData.Id = 1;

			// Cannot instantiate directly because is Abstract
			AComunicador aComunicador = new AComunicador();
		}

		static void MakeTalk(IComunicador com)
		{
			com.Say("Something");
		}
	}
}
