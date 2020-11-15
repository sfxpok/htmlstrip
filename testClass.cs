using Xunit;
//using UtilityLibraries;
//using htmlstrip;

public class testClass
{
    [Fact]
    public void emptyString()
    {

        string expected = "body";
        bool isItWhitespace = string.IsNullOrWhiteSpace(expected);
        Assert.False(isItWhitespace);
    
    }

    [Fact]
    public void capitalizedString()
    {
        var expected = "body";

        for (int i = 0; i < expected.Length; i++)
        {
            bool isItUppercase = char.IsUpper(expected[i]);
            Assert.False(isItUppercase);
        }

    }

    [Fact]
    public void checkForNumbersString()
    {
        var expected = "body";

        for (int i = 0; i < expected.Length; i++)
        {
            bool isItDigit = char.IsDigit(expected[i]);
            Assert.False(isItDigit);
        }
    }


}