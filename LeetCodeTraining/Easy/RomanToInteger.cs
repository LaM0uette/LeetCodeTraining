namespace LeetCodeTraining.Easy;

public class RomanToInteger
{
    public int RomanToInt(string s)
    {
        return s switch
        {
            "I" => 1,
            "II" => 2,
            "III" => 3,
            "IIII" => 4,
            "IV" => 4,
            "V" => 5,
            "VI" => 6,
            "VII" => 7,
            "VIII" => 8,
            "VIIII" => 9,
            "VIV" => 9,
            "VIIIII" => 10,
            "VV" => 10,
        };
    }
}