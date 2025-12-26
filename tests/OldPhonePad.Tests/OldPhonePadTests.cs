using Xunit;

public class OldPhonePadTests
{
    [Fact]
    public void StopsAtHash()
    {
        var result = PhonePad.OldPhonePad("2#222");
        Assert.Equal("A", result);
    }

    [Fact]
    public void StarRemovesPreviousCharacter()
    {
        var result = PhonePad.OldPhonePad("22*2#");
        Assert.Equal("A", result);
    }

    [Fact]
    public void StarAtTheBeginningCharacter()
    {
        var result = PhonePad.OldPhonePad("*2#");
        Assert.Equal("A", result);
    }

    [Fact]
    public void RepeatedDigitsGroupToLetters()
    {
        var result = PhonePad.OldPhonePad("4433555 555666#");
        Assert.Equal("HELLO", result);
        Assert.NotNull(result);
    }
}