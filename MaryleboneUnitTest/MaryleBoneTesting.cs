using MaryleboneTest.Models;
using MaryleboneTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaryleboneUnitTest
{
	public class MaryleBoneTesting
	{
		
		[Theory]
		[InlineData(10)]
		public void GetPrimeNumbers(int primeNumber)
		{
			var result = new List<int> { 2,3,5,7};

			// Arrange
			var primeNumbersService = new PrimeNumbersService();
			var primeNumbers = primeNumbersService.GetPrimeNumbers(primeNumber);
			// Assert
			Assert.Equal(primeNumbers, result);
			
		}
		[Theory]
		[InlineData(1)]
		public void IsNumbersBetween1and100(int number)
		{
			// Arrange
			var primeNumbersService = new PrimeNumbersService();
			var primeNumbers = primeNumbersService.GetPrimeNumbers(number);
			// Assert
			Assert.InRange(number, 1, 100);
		}
	}
}
