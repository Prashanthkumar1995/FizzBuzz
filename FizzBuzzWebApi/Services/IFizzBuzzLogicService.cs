using static FizzBuzzWebApi.Models.FizzBuzzLogicModel;

namespace FizzBuzzWebApi.Services
{
    public interface IFizzBuzzLogicService
    {
        IEnumerable<FizzBuzzLogicResponseModel> CaluculateValue(IEnumerable<string> Values);
    }
}
