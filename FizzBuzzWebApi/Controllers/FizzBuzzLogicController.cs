using FizzBuzzWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static FizzBuzzWebApi.Models.FizzBuzzLogicModel;

namespace FizzBuzzWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzLogicController : ControllerBase
    {
        // Implimenting dependancy injection 
        // Assigning all the methods to this below private variable with out creating object 
        //by cunstructer

        private readonly IFizzBuzzLogicService _FizzBuzzService;
        public FizzBuzzLogicController(IFizzBuzzLogicService  FizzBuzzLogicService)
        {
            _FizzBuzzService = FizzBuzzLogicService;
        }

        // below method will catch the numbers and process
        [HttpPost]
        public IActionResult Post([FromBody] FizzBuzzLogicRequestModel request)
        {
            // without creating object calling the function 
            //Hence we achieved dependancy injection
            var results = _FizzBuzzService.CaluculateValue(request.Values);
            return Ok(results);
        }


    }
}
