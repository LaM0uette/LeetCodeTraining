namespace LeetCodeTraining.Medium;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        var maxArea = 0;
        var left = 0;
        var right = height.Length - 1;

        while (left < right)
        {
            var minHeight = Math.Min(height[left], height[right]);
            var area = minHeight * (right - left);
            
            if (area > maxArea) maxArea = area;
            
            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxArea;
    }
}