using VowelCount;

namespace Test;

public class Tests
{
    //Return the number(count) of vowels in the given string.
    //We will consider a, e, i, o, u as vowels for this Kata(but not y).
    //The input string will only consist of lower case letters and/or spaces.

    [Test]
    public void GetVowelCount_Returns1_WhenGivenOneVowel()
    {
        Assert.AreEqual(1, Kata.GetVowelCount("a"));
    }
    [Test]
    public void GetVowelCount_Returns2_WhenGivenTwoVowel()
    {
        Assert.AreEqual(2, Kata.GetVowelCount("aa"));
    }
    [Test]
    public void GetVowelCount_Returns0_WhenGivenNoVowels()
    {
        Assert.AreEqual(0, Kata.GetVowelCount("b"));
    }

    [Test]
    public void GetVowelCount_Returns5_WhenGivenTheAlphabet()
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        Assert.AreEqual(5, Kata.GetVowelCount(alphabet));
    }
}