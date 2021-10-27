using System;

namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			LazySingletonPOC singleton1 = LazySingletonPOC.GetInstance();
			LazySingletonPOC singleton2 = LazySingletonPOC.GetInstance();
			LazySingletonPOC singleton3 = LazySingletonPOC.GetInstance();

			if(singleton1 == singleton2 && singleton2 == singleton3)
			{
				Console.WriteLine("They are the same!");
			}
			else
			{
				Console.WriteLine("Singleton failed :(");
			}
		}
	}
}
