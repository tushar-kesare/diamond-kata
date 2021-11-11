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
            var expected = "A\\n";

            var result = sut.Create(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_B_should_print_two_lines()
        {
            var input = 'B';
            var expected =
                " A \\n" +
                "B B\\n";

            var result = sut.Create(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_C_should_print_three_lines()
        {
            var input = 'C';
            var expected =
                "  A  \\n" +
                " B B \\n" +
                "C   C\\n";

            var result = sut.Create(input);
            Assert.Equal(expected, result);
        }
    }
}
