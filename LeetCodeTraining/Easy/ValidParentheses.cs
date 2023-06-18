namespace LeetCodeTraining.Easy;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        if (s.Length.Equals(0)) return false;
        
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c is '(' or '[' or '{')
                stack.Push(c);
            else
            {
                var top = stack.Pop();

                if (c.Equals(')') && !top.Equals('(')
                    || c.Equals(']') && !top.Equals('[')
                    || c.Equals('}') && !top.Equals('{')) 
                    return false;
            }
        }
        
        return stack.Count.Equals(0);
    }
}