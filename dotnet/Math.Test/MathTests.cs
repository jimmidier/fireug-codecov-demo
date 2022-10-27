using Xunit;

namespace Math.Test;

public class MathTests
{
    [Fact]
    public void Normal_Division_Should_Return_Correct_Result()
    {
        Assert.Equal(1.5, Math.Divide(3, 2));
    }
}