namespace FizzBuzzWebApi.Factories
{
    public class FizzFactoryPattern: IFizzBuzzFactoryPattern
    {
        public string FinalResults(int value)
        {

            return "Fizz";
        }
    }
    public class BuzzFactoryPattern : IFizzBuzzFactoryPattern
    {
        public string FinalResults(int value)
        {

            return "Buzz";
        }
    }
    public class FizzBuzzFactoryPattern : IFizzBuzzFactoryPattern
    {
        public string FinalResults(int value)
        {

            return "FizzBuzz";
        }
    }
}
