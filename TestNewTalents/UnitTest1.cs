using Xunit;
using NewTalents;
using System;

namespace TestNewTalents
{
    public class UnitTest1
    {
        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 6, 10)]
        public void TestSomar(int val1, int val2, int res)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculadora = calc.Somar(val1, val2);
            Assert.Equal(res, resultadoCalculadora);
                        
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(6, 5, 1)]
        public void TestSubtrair(int val1, int val2, int res)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculadora = calc.Subtrair(val1, val2);
            Assert.Equal(res, resultadoCalculadora);

        }

        [Theory]
        [InlineData(6, 2, 12)]
        [InlineData(6, 5, 30)]
        public void TestMultiplicar(int val1, int val2, int res)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculadora = calc.Multiplicar(val1, val2);
            Assert.Equal(res, resultadoCalculadora);

        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(6, 3, 2)]
        public void TestDividir(int val1, int val2, int res)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculadora = calc.Dividir(val1, val2);
            Assert.Equal(res, resultadoCalculadora);

        }

        
        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();
            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
            );
        }

    }
}