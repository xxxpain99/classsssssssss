using System;

namespace ConsoleApp9
{
	class Program
	{
		static void Main(string[] args)
		{

			Car transport = new Car("mark");
			transport.drives();
			transport.honk();

			Motorcycle transport1 = new Motorcycle("mark");
			transport1.drives();
			transport1.honk();

			Airplane transport3 = new Airplane("model");
			transport3.flying();
			transport3.lands();

			Train transport4 = new Train("mark");
			transport.drives();
			transport.honk();

		   Boat transport5 = new Boat("mark");
			transport.drives();
			transport.honk();
		}

		
	}
	
}
