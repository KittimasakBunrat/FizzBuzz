using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace FizzBuzz.Business.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private FizzBuzz _fizzBuzz;

        public FizzBuzzTests(FizzBuzz fizzBuzz)
        {
            _fizzBuzz = fizzBuzz;
        }

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz(new FizzBuzzRules());
        }

        [Test]
        public void GenerateFizzBuzz_FalseParameters_ListContainFizz()
        {
            List<string> result = _fizzBuzz.GenerateFizzBuzz(false, false, false);
            
            Assert.IsTrue(result.Contains("Fizz"));
        }

        [Test]
        public void GenerateFizzBuzz_FalseParameters_ListContainBuzz()
        {
            List<string> result = _fizzBuzz.GenerateFizzBuzz(false, false, false);

            Assert.IsTrue(result.Contains("Buzz"));
        }


        [Test]
        public void GenerateFizzBuzz_DivisibleByFourTrue_ListContainFuzz()
        {
            List<string> result = _fizzBuzz.GenerateFizzBuzz(true, false, false);

            Assert.IsTrue(result.Contains("Fuzz"));

        }

        [Test]
        public void GenerateFizzBuzz_DivisibleByNineTrue_ListContainJazz()
        {
            List<string> result = _fizzBuzz.GenerateFizzBuzz(false, true, false);

            Assert.IsTrue(result.Contains("Jazz"));

        }

        [Test]
        public void GenerateFizzBuzz_ReverseOrderTrue_ReturnListReversed()
        {
            List<string> result = _fizzBuzz.GenerateFizzBuzz( false, false, true);

            Assert.AreEqual("Buzz", result[0]);
        }
        
    }
}