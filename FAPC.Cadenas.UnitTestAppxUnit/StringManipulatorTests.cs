using Xunit;
using FAPC.Cadenas;

namespace FAPC.Cadenas.UnitTestAppxUnit;

public class StringManipulatorTests
{
    private readonly StringManipulator _manipulator = new();

    // ─── ReverseString ─────────────────────────────────────────────────────

    [Fact]
    public void ReverseString_CadenaSimple_RetornaCadenaInvertida()
    {
        // Arrange
        string input    = "Hola";
        string expected = "aloH";

        // Act
        string actual = _manipulator.ReverseString(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ReverseString_CadenaVacia_RetornaCadenaVacia()
    {
        // Arrange
        string input    = string.Empty;
        string expected = string.Empty;

        // Act
        string actual = _manipulator.ReverseString(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ReverseString_CadenaPalindromo_RetornaMismaCadena()
    {
        // Arrange
        string input    = "reconocer";
        string expected = "reconocer";

        // Act
        string actual = _manipulator.ReverseString(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ReverseString_UnSoloCaracter_RetornaMismoCaracter()
    {
        // Arrange
        string input    = "A";
        string expected = "A";

        // Act
        string actual = _manipulator.ReverseString(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ReverseString_CadenaNula_LanzaArgumentNullException()
    {
        // Arrange
        string? input = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => _manipulator.ReverseString(input!));
    }

    // ─── RemoveSpaces ──────────────────────────────────────────────────────

    [Fact]
    public void RemoveSpaces_CadenaConEspacios_RetornaSinEspacios()
    {
        // Arrange
        string input    = "Hola Mundo";
        string expected = "HolaMundo";

        // Act
        string actual = _manipulator.RemoveSpaces(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void RemoveSpaces_CadenaSinEspacios_RetornaMismaCadena()
    {
        // Arrange
        string input    = "SinEspacios";
        string expected = "SinEspacios";

        // Act
        string actual = _manipulator.RemoveSpaces(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void RemoveSpaces_CadenaVacia_RetornaCadenaVacia()
    {
        // Arrange
        string input    = string.Empty;
        string expected = string.Empty;

        // Act
        string actual = _manipulator.RemoveSpaces(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void RemoveSpaces_SoloEspacios_RetornaCadenaVacia()
    {
        // Arrange
        string input    = "     ";
        string expected = string.Empty;

        // Act
        string actual = _manipulator.RemoveSpaces(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void RemoveSpaces_CadenaNula_LanzaArgumentNullException()
    {
        // Arrange
        string? input = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => _manipulator.RemoveSpaces(input!));
    }
}
