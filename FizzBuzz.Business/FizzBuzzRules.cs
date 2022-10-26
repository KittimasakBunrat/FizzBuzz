namespace FizzBuzz.Business
{
    public class FizzBuzzRules : IFizzBuzzRules

    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string Fuzz = "Fuzz";
        private const string Jazz = "Jazz";


        public string GenerateFizzBuzzWord(int i, bool divisibleByFour, bool divisibleByNine)
        {

            if (divisibleByFour && i % 4 == 0)
            {
                return Fuzz;
            }

            if (divisibleByNine && i % 9 == 0)
            {
                return Jazz;
            }

            if (i % 3 == 0)
            {
                return Fizz;
            }

            if (i % 5 == 0)
            {
                return Buzz;
            }

            return i.ToString();
        }
    }
}
