namespace MathTest;
using Math;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void Add()
    {
        // Arrange
        var expected = 11;
        // Action
        var actual = SimpleMath.Add(5, 6);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(10, 6, 4)]
    [InlineData(11, 3, 8)]
    public void Sub(int param1, int param2, int result)
    {
        // Arange
        var expected = result;
        // Action
        var actual = SimpleMath.Sub(param1, param2);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Divide()
    {
        // Action
        Action action = () => SimpleMath.Divide(10, 0);
        // Assert
        Assert.Throws<System.DivideByZeroException>(action);
    }

    [Fact]
    public async Task DivideAsync()
    {
        // Action
        Func<Task> action = () => SimpleMath.DivideAsync(10, 0);
        // Assert
        await Assert.ThrowsAsync<System.DivideByZeroException>(action);
    }
}