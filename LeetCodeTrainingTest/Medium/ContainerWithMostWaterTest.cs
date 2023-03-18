using LeetCodeTraining.Medium;

namespace LeetCodeTrainingTest.Medium;

public class ContainerWithMostWaterTest
{
    private ContainerWithMostWater ContainerWithMostWater { get; } = new();
    private int GetMaxArea(int[] height) => ContainerWithMostWater.MaxArea(height);
    
    [Fact]
    public void MaxArea_11_1() => 
        Assert.Equal(1, GetMaxArea(new[] {1, 1}));
    
    [Fact]
    public void MaxArea_123_2() => 
        Assert.Equal(2, GetMaxArea(new[] {1, 2, 3}));
    
    [Fact]
    public void MaxArea_223_4() => 
        Assert.Equal(4, GetMaxArea(new[] {2, 2, 3}));
    
    [Fact]
    public void MaxArea_323_6() => 
        Assert.Equal(6, GetMaxArea(new[] {3, 2, 3}));
    
    [Fact]
    public void MaxArea_186254837_49() => 
        Assert.Equal(49, GetMaxArea(new[] {1, 8, 6, 2, 5, 4, 8, 3, 7}));
}