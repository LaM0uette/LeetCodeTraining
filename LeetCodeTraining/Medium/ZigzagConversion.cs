using System.Text;

namespace LeetCodeTraining.Medium;

public class ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;
        
        var rows = new List<StringBuilder> ();
        var row = 0;
        
        for (var i = 0; i < numRows; i++) rows.Add(new StringBuilder());

        foreach (var sChar in s)
        {
            if (row > 1) row = 0;
            rows[row].Append(sChar);
            row++;
        }
        
        var result = new StringBuilder();
        foreach (var sb in rows)
        {
            result.Append(sb);
        }

        return result.ToString();
    }
}