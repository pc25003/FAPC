namespace FAPC.Cadenas;

/// <summary>
/// Proporciona métodos de manipulación de cadenas de texto.
/// </summary>
public class StringManipulator
{
    /// <summary>
    /// Invierte el orden de los caracteres de una cadena.
    /// </summary>
    /// <param name="input">Cadena de entrada.</param>
    /// <returns>La cadena con sus caracteres en orden inverso.</returns>
    /// <exception cref="ArgumentNullException">
    /// Se lanza cuando <paramref name="input"/> es <c>null</c>.
    /// </exception>
    public string ReverseString(string input)
    {
        if (input is null)
            throw new ArgumentNullException(nameof(input), "El parámetro no puede ser nulo.");

        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    /// <summary>
    /// Elimina todos los espacios en blanco de una cadena.
    /// </summary>
    /// <param name="input">Cadena de entrada.</param>
    /// <returns>La cadena sin ningún carácter de espacio.</returns>
    /// <exception cref="ArgumentNullException">
    /// Se lanza cuando <paramref name="input"/> es <c>null</c>.
    /// </exception>
    public string RemoveSpaces(string input)
    {
        if (input is null)
            throw new ArgumentNullException(nameof(input), "El parámetro no puede ser nulo.");

        return input.Replace(" ", string.Empty);
    }
}
