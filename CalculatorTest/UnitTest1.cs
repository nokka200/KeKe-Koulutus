namespace CalculatorTest;
using Logic;

[TestClass]
public class Calculator_Adder
{
    [TestMethod]
    [DataRow(1, 2, DisplayName = "1 + 2 = 3")]
    [DataRow(2, 3, DisplayName = "2 + 3 = 5")]
    public void Adder_IntTwoNumbers_ReturnTrue(int first, int second)
    {
        // Arrange
        int compare = first + second;

        // Act
        var result = Calculator.Adder(first, second);

        // Assert
        Assert.AreEqual(compare, result);
    }

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
}