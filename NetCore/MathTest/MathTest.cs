namespace MathTest;
using Math;

public class MathTest
{
    [Fact]
    public void Test_Add()
    {
        var actual = SimpleMath.Add(4, 7);
        Assert.Equal(11, actual);
    }
}