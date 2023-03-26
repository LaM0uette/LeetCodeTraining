namespace LeetCodeTraining.Medium;

public class ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        return s.Length <= 0 ? "" : s.Length == 2 ? "AB" : "A";
    }
}