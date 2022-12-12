namespace MaryleboneTest.Models
{
	public class PrimeNumber
	{
		public int primeNumber { get; set; }
	}

	public interface IPrimeNumberService
	{
		List<int> GetPrimeNumbers(int primeNumber);
	}
}
