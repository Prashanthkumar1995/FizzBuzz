namespace FizzBuzzWebApi.Models
{
    public class FizzBuzzLogicModel
    {
         
        // below class implimentimg single responsiblity for request
        public class FizzBuzzLogicRequestModel
        {
            public IEnumerable<string> Values {  get; set; }
        }
        // below class implimentimg single responsiblity for Response
        
        public class FizzBuzzLogicResponseModel
        {
            public string Finalresult { get; set; }
            public List<string> Logresult { get; set; }
        }
    }
}
