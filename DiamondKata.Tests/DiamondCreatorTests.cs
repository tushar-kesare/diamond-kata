using System;
using Xunit;

namespace DiamondKata.Tests
{
    public class DiamondCreatorTests
    {
        private readonly DiamondCreator sut = new DiamondCreator();

        [Fact]
        public void When_A_should_print_A()
        {
            var input = 'A';
            var expected = "A";

            var result = sut.Create(input);
            Assert.Equal(expected, result);
        }
    }
}
