using Calculadora.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTestes.ServicesTests
{
    public class ValidacaoStringTests
    {
        private ValidacaoString _stringValidation;

        public ValidacaoStringTests()
        {
            _stringValidation = new ValidacaoString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            // Arrange
            string texto = "Ola";

            // Act
            int result = _stringValidation.ContadorCaracteres(texto);

            // Assert
            Assert.Equal(3, result);
        }
    }
}
