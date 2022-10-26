namespace FizzBuzz.Business
{
    public class FizzBuzz : IFizzBuzz
    {
        private readonly IFizzBuzzRules _fizzBuzzRules;
        private const int UpperLimit = 100;
        private const int LowerLimit = 1;

        public FizzBuzz(IFizzBuzzRules fizzBuzzRules)
        {
            _fizzBuzzRules = fizzBuzzRules;
        }

        public List<string> GenerateFizzBuzz(bool divisibleByFour, bool divisibleByNine, bool reverseOrder)
        {
            var fizzBuzz = new List<string>();

            var counter = reverseOrder ? UpperLimit : LowerLimit;
            if (reverseOrder)
            {
                while (counter >= LowerLimit)
                {
                    fizzBuzz.Add(_fizzBuzzRules.GenerateFizzBuzzWord(counter, divisibleByFour, divisibleByNine));
                    counter--;
                }
            }
            else
            {
                while (counter <= UpperLimit)
                {
                    fizzBuzz.Add(_fizzBuzzRules.GenerateFizzBuzzWord(counter, divisibleByFour, divisibleByNine));
                    counter++;
                }
            }

            return fizzBuzz;
        }
    }
}
