using Microsoft.AspNetCore.Mvc;
using RestWithASP_NET5Udemy.Services;

namespace RestWithASP_NET5Udemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {        
        private readonly ILogger<PersonController> _logger;
        private IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string? firstNumber = "0", string? secondNumber = "0")
        {
            

            return BadRequest("Invalid Input");
        }

        //[HttpGet("subtract/{firstNumber}/{secondNumber}")]
        //public IActionResult Subtract(string? firstNumber = "0", string? secondNumber = "0")
        //{
        //    if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        //    {
        //        var subtract = ConvertToDesimal(firstNumber) - ConvertToDesimal(secondNumber);

        //        return Ok(subtract);
        //    }

        //    return BadRequest("Invalid Input");
        //}

        //[HttpGet("multiply/{firstNumber}/{secondNumber}")]
        //public IActionResult Multiply(string? firstNumber = "0", string? secondNumber = "0")
        //{
        //    if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        //    {
        //        var multiply = ConvertToDesimal(firstNumber) * ConvertToDesimal(secondNumber);

        //        return Ok(multiply);
        //    }

        //    return BadRequest("Invalid Input");
        //}

        //[HttpGet("split/{firstNumber}/{secondNumber}")]
        //public IActionResult Split(string? firstNumber = "0", string? secondNumber = "0")
        //{
        //    if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        //    {
        //        var split = ConvertToDesimal(firstNumber) / ConvertToDesimal(secondNumber);

        //        return Ok(split);
        //    }

        //    return BadRequest("Invalid Input");
        //}

        //[HttpGet("square-root/{firstNumber}")]
        //public IActionResult SquareRoot(string? firstNumber = "0")
        //{
        //    if (IsNumeric(firstNumber))
        //    {
        //        var squareroot = Math.Sqrt((double)ConvertToDesimal(firstNumber)) ;

        //        return Ok(squareroot);
        //    }

        //    return BadRequest("Invalid Input");
        //}

        //private decimal ConvertToDesimal(string? firstNumber = "0")
        //{
        //    decimal result = 0;
        //    decimal.TryParse(firstNumber, out result);
        //    return result;
        //}

        //private bool IsNumeric(string? firstNumber = "0")
        //{
        //    double number = 0;
        //    bool isNumber = double.TryParse(firstNumber, out number);

        //    return isNumber;
        //}
    }
}
