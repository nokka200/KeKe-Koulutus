namespace Logic;

static public class Calculator
{
    /// <summary>
    /// Tämä metodi lisää kaksi numeroa ja palauttaa aina positiivisen tuloksen.
    /// </summary>
    /// <param name="first">Ensimmäinen numero</param>
    /// <param name="second">Toinen numero</param>
    /// <returns>Positiivinen arvo</returns>
    static public int Adder(int first, int second)
    {
        return first + second;
    }

    /*
    static public int Adder(int first, int second)
    {
        return Math.Abs(first + second);
    }
    */
}
