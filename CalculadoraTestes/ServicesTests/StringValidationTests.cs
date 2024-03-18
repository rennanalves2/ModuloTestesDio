using Calculadora.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTestes.ServicesTests
{
    public class StringValidationTests
    {
        private StringValidation _stringValidation;

        public StringValidationTests()
        {
            _stringValidation = new StringValidation();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            // Arrange
            var text = "Ola";

            // Act
            var result = _stringValidation.CountChar(text);

            // Assert
            Assert.Equal(3, result);
        }
    }
}
