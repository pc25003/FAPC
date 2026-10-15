using Microsoft.VisualStudio.TestTools.UnitTesting;
using FAPC.Temperatura;

namespace FAPC.Temperatura.UnitTestMSTest;

[TestClass]
public class TemperatureConverterTests
{
    private readonly TemperatureConverter _converter = new();

    // ─── CelsiusToFahrenheit ───────────────────────────────────────────────

    [TestMethod]
    [TestCategory("CelsiusToFahrenheit")]
    public void CelsiusToFahrenheit_PuntoCongelacion_Retorna32()
    {
        // Arrange
        double celsius = 0.0;
        double expected = 32.0;

        // Act
        double actual = _converter.CelsiusToFahrenheit(celsius);

        // Assert
        Assert.AreEqual(expected, actual, 0.0001,
            "El punto de congelación (0 °C) debe ser 32 °F.");
    }

    [TestMethod]
    [TestCategory("CelsiusToFahrenheit")]
    public void CelsiusToFahrenheit_PuntoEbullicion_Retorna212()
    {
        // Arrange
        double celsius = 100.0;
        double expected = 212.0;

        // Act
        double actual = _converter.CelsiusToFahrenheit(celsius);

        // Assert
        Assert.AreEqual(expected, actual, 0.0001,
            "El punto de ebullición (100 °C) debe ser 212 °F.");
    }

    [TestMethod]
    [TestCategory("CelsiusToFahrenheit")]
    public void CelsiusToFahrenheit_TemperaturaCorpohumana_Retorna986()
    {
        // Arrange
        double celsius = 37.0;
        double expected = 98.6;

        // Act
        double actual = _converter.CelsiusToFahrenheit(celsius);

        // Assert
        Assert.AreEqual(expected, actual, 0.0001,
            "La temperatura corporal (37 °C) debe ser 98.6 °F.");
    }

    [TestMethod]
    [TestCategory("CelsiusToFahrenheit")]
    public void CelsiusToFahrenheit_ValorNegativo_RetornaFahrenheitNegativo()
    {
        // Arrange
        double celsius = -40.0;
        double expected = -40.0;   // −40 °C == −40 °F

        // Act
        double actual = _converter.CelsiusToFahrenheit(celsius);

        // Assert
        Assert.AreEqual(expected, actual, 0.0001,
            "-40 °C debe ser exactamente -40 °F.");
    }

    // ─── FahrenheitToCelsius ───────────────────────────────────────────────

    [TestMethod]
    [TestCategory("FahrenheitToCelsius")]
    public void FahrenheitToCelsius_PuntoCongelacion_Retorna0()
    {
        // Arrange
        double fahrenheit = 32.0;
        double expected = 0.0;

        // Act
        double actual = _converter.FahrenheitToCelsius(fahrenheit);

        // Assert
        Assert.AreEqual(expected, actual, 0.0001,
            "El punto de congelación (32 °F) debe ser 0 °C.");
    }

    [TestMethod]
    [TestCategory("FahrenheitToCelsius")]
    public void FahrenheitToCelsius_PuntoEbullicion_Retorna100()
    {
        // Arrange
        double fahrenheit = 212.0;
        double expected = 100.0;

        // Act
        double actual = _converter.FahrenheitToCelsius(fahrenheit);

        // Assert
        Assert.AreEqual(expected, actual, 0.0001,
            "El punto de ebullición (212 °F) debe ser 100 °C.");
    }

    [TestMethod]
    [TestCategory("FahrenheitToCelsius")]
    public void FahrenheitToCelsius_TemperaturaCorporal_Retorna37()
    {
        // Arrange
        double fahrenheit = 98.6;
        double expected = 37.0;

        // Act
        double actual = _converter.FahrenheitToCelsius(fahrenheit);

        // Assert
        Assert.AreEqual(expected, actual, 0.0001,
            "La temperatura corporal (98.6 °F) debe ser 37 °C.");
    }

    [TestMethod]
    [TestCategory("FahrenheitToCelsius")]
    public void FahrenheitToCelsius_PuntoDeEquivalencia_RetornaMinusCuarenta()
    {
        // Arrange
        double fahrenheit = -40.0;
        double expected = -40.0;   // −40 °F == −40 °C

        // Act
        double actual = _converter.FahrenheitToCelsius(fahrenheit);

        // Assert
        Assert.AreEqual(expected, actual, 0.0001,
            "-40 °F debe ser exactamente -40 °C.");
    }
}
