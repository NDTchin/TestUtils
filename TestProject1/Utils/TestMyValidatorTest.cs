using WebApplication2.Utils;

namespace TestProject1.Utils;

public class TestMyValidatorTest
{
    [Fact]
    public void IsEmail()
    {
        TestMyValidator m = new TestMyValidator();
        var result = m.IsEmail("test@example.com");
        Assert.True(result);
    }
    [Fact]
    public void IsVietnamesePhoneNumber_ValidPhone_ReturnsTrue()
    {
        TestMyValidator validator = new TestMyValidator();
        var result = validator.IsVietnamesePhoneNumber("0912345678");
        Assert.True(result);
    }
    public void IsVietnamesePhoneNumber_InvalidPhone_ReturnsFalse()
    {
        TestMyValidator validator = new TestMyValidator();
        var result = validator.IsVietnamesePhoneNumber("12345");
        Assert.False(result);
    }
    [Fact]
    public void IsValidUrl_ValidUrl_ReturnsTrue()
    {
        TestMyValidator validator = new TestMyValidator();
        var result = validator.IsValidUrl("https://www.example.com");
        Assert.True(result);
    }
    [Fact]
    public void IsValidUrl_InvalidUrl_ReturnsFalse()
    {
        TestMyValidator validator = new TestMyValidator();
        var result = validator.IsValidUrl("invalid-url");
        Assert.False(result);
    }
}

public class MyValidatorTest
{
}