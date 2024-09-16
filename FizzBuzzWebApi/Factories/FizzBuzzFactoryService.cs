namespace FizzBuzzWebApi.Factories
{
    public class FizzBuzzFactoryService
    {
        //Implimenting factory pattern below
      public IFizzBuzzFactoryPattern result(int value)
        {
            switch(value)
            {
                case 3:
                    return new FizzFactoryPattern();
                case 5:
                    return new BuzzFactoryPattern();
                case 15:
                    return new FizzBuzzFactoryPattern();
                default:
                    throw new ArgumentException("Invalid Value");
            }
        }
    }
}
