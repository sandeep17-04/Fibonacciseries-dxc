using ConsoleApp4;

namespace ConsoleUnitTest
{
    public class FibonacciSeriesTests
    {
        private readonly FibonacciSeries series;

        public FibonacciSeriesTests()
        {
            series = new FibonacciSeries();
        }
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(1)]
        [InlineData(2)]
        public void FibonacciSeries_Get_Fail(int count)
        {
            var ser = series.Get(count);
            Assert.NotNull(ser);
            Assert.Equal(0, ser.Length);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void FibonacciSeries_Get_Success(int count)
        {
            var ser = series.Get(count);
            Assert.NotNull(ser);
            Assert.Equal(count, ser.Length);
        }
    }
}