using NUnit.Framework;

namespace FizzBuzz.Business.Tests;

[TestFixture]
public class FizzBuzzRulesTests
{
    [SetUp]
    public void SetUp()
    {
        _fizzBuzzRules = new FizzBuzzRules();
    }

    private FizzBuzzRules _fizzBuzzRules;

    public FizzBuzzRulesTests(FizzBuzzRules fizzBuzzRules)
    {
        _fizzBuzzRules = fizzBuzzRules;
    }

    [Test]
    public void GenerateFizzBuzzWord_ParameterHasNoRules_ReturnParameterAsString()
    {
        var result = _fizzBuzzRules.GenerateFizzBuzzWord(2, false, false);
        var result1 = _fizzBuzzRules.GenerateFizzBuzzWord(7, false, false);

        Assert.AreEqual("2", result);
        Assert.AreEqual("7", result1);
    }

    [Test]
    public void GenerateFizzBuzzWord_ParameterIsDivisibleByThree_ReturnFizz()
    {
        const string expectedResult = "Fizz";

        var result = _fizzBuzzRules.GenerateFizzBuzzWord(3, false, false);
        var result1 = _fizzBuzzRules.GenerateFizzBuzzWord(6, false, false);

        Assert.AreEqual(expectedResult, result);
        Assert.AreEqual(expectedResult, result1);
    }


    [Test]
    public void GenerateFizzBuzzWord_ParameterIsDivisibleByFive_ReturnBuzz()
    {
        const string expectedResult = "Buzz";

        var result = _fizzBuzzRules.GenerateFizzBuzzWord(5, false, false);
        var result1 = _fizzBuzzRules.GenerateFizzBuzzWord(10, false, false);

        Assert.AreEqual(expectedResult, result);
        Assert.AreEqual(expectedResult, result1);
    }

    [Test]
    public void GenerateFizzBuzzWord_ParameterIsDivisibleByFour_ReturnFuzz()
    {
        const string expectedResult = "Fuzz";

        var result = _fizzBuzzRules.GenerateFizzBuzzWord(4, true, false);
        var result1 = _fizzBuzzRules.GenerateFizzBuzzWord(8, true, false);

        Assert.AreEqual(expectedResult, result);
        Assert.AreEqual(expectedResult, result1);
    }

    [Test]
    public void GenerateFizzBuzzWord_ParameterIsDivisibleByNine_ReturnJazz()
    {
        const string expectedResult = "Jazz";

        var result = _fizzBuzzRules.GenerateFizzBuzzWord(9, false, true);
        var result1 = _fizzBuzzRules.GenerateFizzBuzzWord(18, false, true);

        Assert.AreEqual(expectedResult, result);
        Assert.AreEqual(expectedResult, result1);
    }
}