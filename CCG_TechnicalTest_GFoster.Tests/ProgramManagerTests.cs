using Xunit;

namespace CCG_TechnicalTest_GFoster.Tests
{
    public class ProgramManagerTests
    {
        // There are simplistic tests placed here in order to indicate the use of xUNIT testing
        // and how tests are run/evaluated within a solution - Can be applied to the console
        // once complete.

        [Fact]
        public void TrueEqualsTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void TrueDoesNotEqualFalse()
        {
            Assert.False(false);
        }

        // This has been deliberatley coded to generate a failure!
        [Fact]
        public void XIsNotEqualToYFact()
        {
            Assert.Equal(10, 9);
        }

        [Theory]
        [InlineData(100, 50, 50)]
        [InlineData(100, 1, 99)]
        [InlineData(100, 72, 28)]
        public void XIsNotEqualToYTheory(int expected, int first, int second)
        {
            var tot = first + second;
            Assert.Equal(expected, tot);
        }
    }
}
