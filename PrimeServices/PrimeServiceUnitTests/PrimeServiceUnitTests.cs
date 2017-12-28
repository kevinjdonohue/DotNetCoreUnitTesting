using System;
using Xunit;
using Prime.Services;

namespace Prime.Services.UnitTests
{
    public class PrimeServiceUnitTests
    {
        private readonly PrimeService _primeService;

        public PrimeServiceUnitTests()
        {
            _primeService = new PrimeService();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ShouldReturnFalse_GivenValueLessThan2(int value)
        {
            //act
            bool result = _primeService.IsPrime(value);

            //assert
            Assert.False(result, "${value} is not prime.");
        }
    }
}
