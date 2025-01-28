using calculatorApp;
using Xunit;

namespace calculatorTests
{
    public class calculatorTests
    {
        private calculatorImp _calc;

        public calculatorTests()
        {
            _calc = new calculatorImp();
        }

        [Fact]
        public void DeveSomar5Com10ERetornar15()
        {
            int num1 = 5;
            int num2 = 10;
            int resultado = _calc.Somar(num1, num2);
            Assert.Equal(15, resultado);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(10)]
        public void DeveVerificarSeOsNumerosSaoPares(int num1)
        {
            Assert.True(_calc.EhPar(num1));
        }
    }
}
   