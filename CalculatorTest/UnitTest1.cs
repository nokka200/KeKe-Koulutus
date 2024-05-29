namespace CalculatorTest;
using Logic;

/// <summary>
/// Tämä luokka testaa Calculator-luokan Adder-metodia.
/// </summary>
[TestClass] // Tässä ilmoitetaan, että kyseinen luokka on Testi luokka
public class Calculator_Adder
{

    [TestMethod] // Tässä ilmoitetaan, että kyseinen metodi on Testi metodi
    [DataRow(1, 2, DisplayName = "1 + 2 = 3")] // Tässä annetaan metodille parametreja ja lisätietoa, joka näkyy testeissä
    [DataRow(2, 3, DisplayName = "2 + 3 = 5")]
    public void Adder_IntTwoNumbers_ReturnTrue(int first, int second)
    {
        // Arrange = Alustetaan muuttujia ja dataa mitä testissä tarvitaan
        int compare = first + second;

        // Act = Suoritetaan testi
        var result = Calculator.Adder(first, second);

        // Assert = Arvioidaan tulosta
        Assert.AreEqual(compare, result);
    }

    /*
    [TestMethod]
    [DataRow(-1, -2, DisplayName = "-1 + -2 = 3")]
    [DataRow(-2, -3, DisplayName = "-2 + -3 = 5")]
    public void Adder_IntTwoNegativeNumbers_ReturnTrue(int first, int second)
    {
        // Arrange
        int compare = Math.Abs(first + second);

        // Act
        var result = Calculator.Adder(first, second);

        // Assert
        Assert.AreEqual(compare, result);
    }
    */
}