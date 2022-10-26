namespace FizzBuzz.Business
{
    public interface IFizzBuzz
    {
        List<string> GenerateFizzBuzz(bool divisibleByFour, bool divisibleByNine, bool reverseOrder);
    }

}