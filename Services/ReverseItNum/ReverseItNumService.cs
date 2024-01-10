namespace DresselZFivetoSevenEndpoints.Services.ReverseItNum;

public class ReverseItNumService : IReverseItNumService
{
    public string ReverseItNum(int num1)
    {
        string num2 = num1.ToString();
        Char[] string1 = num2.ToCharArray();
        Array.Reverse(string1);
        return $"You entered {num1}, reversed is {new string(string1)}.";
    }
}
