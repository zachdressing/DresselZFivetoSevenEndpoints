namespace DresselZFivetoSevenEndpoints.Services.ReverseItAlpha;

public class ReverseItAlphaService : IReverseItAlphaService
{
    public string ReverseItAlpha(string string1)
    {
        Char[] string2 = string1.ToCharArray();
        Array.Reverse(string2);
        return $"You entered {string1}, reversed is {new string(string2)}";
    }
}
