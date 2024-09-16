namespace FizzBuzzWebApi.Factories
{
    public class FizzBuzzFactoryService
    {
        //Implimenting factory pattern below
      public IFizzBuzzFactoryPattern result(int value)
        {
            switch(value)
            {
                case int _ when value % 3 == 0 && value % 5 == 0:
                    return new FizzBuzzFactoryPattern();
                case int _ when value % 3 == 0:
                    return new FizzFactoryPattern();
                case int _ when value % 5 == 0:
                    return new BuzzFactoryPattern();
                default:
                    throw new ArgumentException("Invalid Value");
            }
        }
    }
}
