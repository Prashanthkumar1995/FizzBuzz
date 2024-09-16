using FizzBuzzWebApi.Factories;
using FizzBuzzWebApi.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FizzBuzzWebApi.Tests
{
    public class FizzBuzzLogicServiceTests
    {
        //private readonly FizzBuzzLogicService _FizzBuzzLogicservice;

        private readonly FizzBuzzLogicService _FizzBuzzLogicservice ;
        public FizzBuzzLogicServiceTests()
        {
            var factoryService = new FizzBuzzFactoryService();
            _FizzBuzzLogicservice = new FizzBuzzLogicService(factoryService);
            
        }
        [Fact]
        public void CaluculateValue_WhenDivisibleBy3()
        {
            var input = new[] { "3" };
            var result = _FizzBuzzLogicservice.CaluculateValue(input);
            var resultModel = result.FirstOrDefault();
            Assert.NotNull(resultModel);
            Assert.Contains("Fizz", resultModel.Finalresult);
        }

        [Fact]
        public void CaluculateValue_WhenDivisibleBy5()
        {
            var input = new[] { "5" };
            var result = _FizzBuzzLogicservice.CaluculateValue(input);
            var resultModel = result.FirstOrDefault();
            Assert.NotNull(resultModel);
            Assert.Contains("Buzz", resultModel.Finalresult);
        }
        [Fact]
        public void CaluculateValue_WhenDivisibleByBoath3and5()
        {
            var input = new[] { "15","30", "45" };
            var result = _FizzBuzzLogicservice.CaluculateValue(input);
            var resultModel = result.FirstOrDefault();
            Assert.NotNull(resultModel);
            Assert.Contains("FizzBuzz", resultModel.Finalresult);
        }

        [Fact]
        public void CaluculateValue_WhenInvalidItem()
        {
            var input = new[] { "A" };
            var result = _FizzBuzzLogicservice.CaluculateValue(input);
            var resultModel = result.FirstOrDefault();
            Assert.NotNull(resultModel);
            Assert.Contains("Invalid Item", resultModel.Finalresult);
        }
    }
}
