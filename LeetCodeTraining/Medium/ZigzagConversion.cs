using System.Text;

namespace LeetCodeTraining.Medium;

public class ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        if (numRows.Equals(1) || numRows >= s.Length) return s;
        
        var rows = new List<StringBuilder> ();
        var row = 0;
        var reverse = false;
        
        for (var i = 0; i < numRows; i++) rows.Add(new StringBuilder());

        foreach (var sChar in s)
        {
            rows[row].Append(sChar);

            if (row.Equals(0) || row.Equals(numRows - 1)) reverse = !reverse;
            row += reverse ? 1 : -1;
        }
        
        var result = new StringBuilder();
        
        foreach (var sb in rows)
        {
            result.Append(sb);
        }

        return result.ToString();
    }
}