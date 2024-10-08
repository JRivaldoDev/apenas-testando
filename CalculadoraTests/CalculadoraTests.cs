using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Calculadora.Services;

namespace CalculadoraTests
{
    public class CalculadoraTests
    {

        private Calculator _calc;

        public CalculadoraTests()
        {
            _calc = new Calculator();
        }
        
        [Fact]
        public void DeveSomar9Com9ERetornar18()
        {
            // Arrange
            int a = 9;
            int b = 9;

            // Act
            var resultado = _calc.Somar(a,b);

            // Assert
            Assert.Equal(18, resultado);
        }

        [Fact]
        public void DeveSubtrair9Com9ERetornar0()
        {
            // Arrange
            int a = 9;
            int b = 9;

            // Act
            var resultado = _calc.Subtrair(a,b);

            // Assert
            Assert.Equal(0, resultado);
        }

        [Fact]
        public void DeveMultiplicar9Com9Retornar81()
        {
            // Arrange
            int a = 9;
            int b = 9;

            // Act
            var resultado = _calc.Multiplicar(a,b);

            // Assert
            Assert.Equal(81, resultado);
        }

        [Fact]
        public void DeveDividir9com9ERetornar1()
        {
            // Arrange
            int a = 9;
            int b = 9;

            // Act
            var resultado = _calc.Dividir(a,b);

            // Assert
            Assert.Equal(1, resultado);
        }
    }
}