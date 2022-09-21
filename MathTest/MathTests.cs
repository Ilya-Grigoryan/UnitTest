namespace MathTest;
using Math;
using Moq;

public class MathTest
{
    /*
    [Fact]  
    public void UnrealTest()  
    {  
        var math = new ISimpleMath();
        Assert.Equal(4, math.Add(2, 2));  
    }
    */
    [Fact]  
    public void MockTest()  
    {  
        var math = new Mock<ISimpleMath>();  
        math.Setup(x => x.Add(2, 2)).Returns(4);  
        Assert.Equal(4, math.Object.Add(2, 2));  
    }  
}