using FizzBuzzWebApi.Factories;
using static FizzBuzzWebApi.Models.FizzBuzzLogicModel;
namespace FizzBuzzWebApi.Services
{
    public class FizzBuzzLogicService: IFizzBuzzLogicService
    {
        private readonly FizzBuzzFactoryService _FizzBuzzFactoryService;

        List<FizzBuzzLogicResponseModel> _FizzBuzzLogicResponseModel = new List<FizzBuzzLogicResponseModel>();
       
        public FizzBuzzLogicService(FizzBuzzFactoryService FizzBuzzFactoryService)
        {
            _FizzBuzzFactoryService = FizzBuzzFactoryService;        
        }

        // Calculating the logic
       public IEnumerable<FizzBuzzLogicResponseModel> CaluculateValue(IEnumerable<string> values)
        {
          
            foreach (var item in values)
            {
                var response = new FizzBuzzLogicResponseModel
                {
                    Logresult = new List<string>()
                };
                if (int.TryParse(item, out int number))
                {
                    if (number == 3 || number == 5 || number == 15)
                    {
                         if (number % 15 == 0)
                        {
                            var res = _FizzBuzzFactoryService.result(number);
                            response.Finalresult = res.FinalResults(number);
                        }
                        else if (number % 3 == 0)
                        {
                            var res = _FizzBuzzFactoryService.result(number);
                            response.Finalresult = res.FinalResults(number);
                        }


                        else if (number % 5 == 0)
                        {
                            var res = _FizzBuzzFactoryService.result(number);
                            response.Finalresult = res.FinalResults(number);
                        }
                        
                    }
                    else
                    {
                        response.Finalresult = number.ToString();
                        response.Logresult.Add($"Divided {number} by 3");
                        response.Logresult.Add($"Divided {number} by 5");
                    }
                }
                else
                {
                    response.Finalresult = "Invalid Item ";
                }
                _FizzBuzzLogicResponseModel.Add(response);
            }
            return _FizzBuzzLogicResponseModel; 
        }
    }
}
