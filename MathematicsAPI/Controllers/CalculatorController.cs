using MathematicsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MathematicsAPI.Controllers
{
    //Controller
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : Controller
    {
        //Injecting repo into constructor
        private readonly ICalculateRepo _calculateRepo;

        public CalculatorController(ICalculateRepo calculateRepo)
        {
            _calculateRepo=calculateRepo;
        }
        
        
        [HttpGet("Add")]
        [ProducesResponseType(200)]
        public IActionResult Add(int a, int b)
        {
            
            var result = _calculateRepo.Add(a, b);
            return Ok(result);
        }

        [HttpGet("Substract")]
        [ProducesResponseType(200)]
        public IActionResult Substract(int a, int b)
        {
           
            var result = _calculateRepo.Substract(a, b);
            return Ok(result);
        }

        [HttpGet("Divide")]
        [ProducesResponseType(200)]
        public IActionResult Divide(int a, int b)
        {
           
            var result = _calculateRepo.Divide(a, b);
            return Ok(result);
        }

        [HttpGet("Multiply")]
        [ProducesResponseType(200)]
        public IActionResult Multiply(int a, int b)
        {
            var result = _calculateRepo.Multiply(a, b);
            return Ok(result);
        }
    }
}
