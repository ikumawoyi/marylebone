using MaryleboneTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaryleboneTest.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class PrimeNumbersController : ControllerBase
	{
		//private readonly PrimeNumbersService _primeNumbersService;
		//public PrimeNumbersController(PrimeNumbersService primeNumbersService)
		//{
		//	_primeNumbersService = primeNumbersService;
		//}

		[HttpGet("{primeNumber}")]
		public List<int> GetPrimeNumbers(int primeNumber)
		{
			var primeNumbersService = new PrimeNumbersService();
			var result = primeNumbersService.GetPrimeNumbers(primeNumber);
			return result;
		}
	}
}
