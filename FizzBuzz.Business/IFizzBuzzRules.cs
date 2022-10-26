namespace FizzBuzz.Business
{
    public interface IFizzBuzzRules
    {
        public string GenerateFizzBuzzWord(int i, bool divisibleByFour, bool divisibleByNine);
    }
}
