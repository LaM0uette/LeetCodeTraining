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

    [Fact]
    public void CheckMaxLength_5_true() =>
        Assert.True(ContainerWithMostWater.CheckMaxLength(5));
    
    [Fact]
    public void CheckMaxLength_100000_true() =>
        Assert.True(ContainerWithMostWater.CheckMaxLength(100000));
    
    [Fact]
    public void CheckMaxLength_100001_false() =>
        Assert.False(ContainerWithMostWater.CheckMaxLength(100001));
    
    [Fact]
    public void CheckHeight_5_true() =>
        Assert.True(ContainerWithMostWater.CheckHeight(5));
    
    [Fact]
    public void CheckHeight_10000_true() =>
        Assert.True(ContainerWithMostWater.CheckHeight(10000));
    
    [Fact]
    public void CheckHeight_10001_false() =>
        Assert.False(ContainerWithMostWater.CheckHeight(10001));
}