using MaryleboneTest.Models;

namespace MaryleboneTest.Services
{
	public class PrimeNumbersService : IPrimeNumberService
	{
		public List<int> GetPrimeNumbers(int primeNumber)
		{
			List<int> PrimeNumbers = new List<int>();
			bool isPrime = true;
			if (primeNumber >= 1 && primeNumber <= 100)
			{
				for (int i = 2; i < primeNumber; i++)
				{
					for (int j = 2; j < primeNumber; j++)
					{
						if (i != j && i % j == 0)
						{
							isPrime = false;

							break;
						}
					}

					if (isPrime)
					{
						PrimeNumbers.Add(i);
					}

					isPrime = true;
				}
			}
			return PrimeNumbers;
		}

	}
}
