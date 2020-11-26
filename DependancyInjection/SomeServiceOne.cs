using System;

namespace DependancyInjection
{
	public class SomeServiceOne : ISomeService
	{
		//private readonly Guid _randomGuid = Guid.NewGuid();
		private readonly IRandomGuidProvider _randomGuidProvider;

		public SomeServiceOne(IRandomGuidProvider randomGuidProvider)
		{
			_randomGuidProvider = randomGuidProvider;
		}
			
		public void PrintSomething()
		{
			Console.WriteLine(_randomGuidProvider.RandomGuid);
		}
	}
}