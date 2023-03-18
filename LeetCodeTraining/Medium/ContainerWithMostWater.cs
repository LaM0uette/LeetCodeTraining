namespace LeetCodeTraining.Medium;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        var n = height.Length;
        if (!CheckMaxLength(n)) return 0;
        
        var maxArea = 0;
        var left = 0;
        var right = height.Length - 1;

        while (left < right)
        {
            var minHeight = Math.Min(height[left], height[right]);
            if (!CheckHeight(minHeight)) return 0;
            
            var area = minHeight * (right - left);
            
            if (area > maxArea) maxArea = area;
            
            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxArea;
    }

    public static bool CheckMaxLength(int n)
    {
        return n >= 2 && n <= Math.Pow(10, 5);
    }
    
    public static bool CheckHeight(int h)
    {
        return h >= 0 && h <= Math.Pow(10, 4);
    }
}