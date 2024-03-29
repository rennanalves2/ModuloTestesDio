using Calculadora.Services;
using NuGet.Frameworks;
using System;

namespace CalculadoraTestes.ServicesTests;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int result = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;

        // Act
        int result = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(20, result);
    }

    [Fact]
    public void DeveVerificarSe4EParERetornarVerdadeiro()
    {
        // Arrange
        int num = 4;

        // Act
        bool result = _calc.EhPar(num);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero)
    {
        // Arrange

        // Act
        bool result = _calc.EhPar(numero);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeAListaDeNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        // Arrange

        // Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}