namespace DresselZFivetoSevenEndpoints.Services.MadLib
{
    public class MadLibService : IMadLibService
    {
        public string MadLib(string string1, string string2, string string3)
        {
            return $"{string1} likes to {string2} at the {string3}";
        }
    }
}