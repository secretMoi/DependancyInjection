using System;
using DependancyInjection.DependancyInjection;

namespace DependancyInjection
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1 enregistre les services
			// 2 génère/instancie les containers
			// 3 utiliser
			
			var services = new DiServiceCollection();

			// singleton instancié seulement la première fois
			//services.RegisterSingleton<RandGuidGenerator>();
			//services.RegisterSingleton(new RandGuidGenerator());
			
			// transient instancié à chaque appel
			//services.RegisterTransient<RandGuidGenerator>();
			
			// avec interfaces
			/*services.RegisterTransient<ISomeService, SomeServiceOne>();
			services.RegisterTransient<IRandomGuidProvider, RandomGuidProvider>();*/
			
			// interfzces + singelton
			services.RegisterSingleton<ISomeService, SomeServiceOne>();
			services.RegisterSingleton<IRandomGuidProvider, RandomGuidProvider>();
			
			var container = services.GenerateContainer();
			
			var serviceFirst = container.GetService<ISomeService>();
			var serviceSecond = container.GetService<ISomeService>();
			
			serviceFirst.PrintSomething();
			serviceSecond.PrintSomething();

			/*var serviceFirst = container.GetService<RandGuidGenerator>();
			var serviceSecond = container.GetService<RandGuidGenerator>();
			
			Console.WriteLine(serviceFirst.RandomGuid);
			Console.WriteLine(serviceSecond.RandomGuid);*/
		}
	}
}
