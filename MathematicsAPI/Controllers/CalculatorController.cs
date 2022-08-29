using MathematicsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MathematicsAPI.Controllers
{
    //Controller
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : Controller
    {
        private readonly ICalculateRepo _calculateRepo;

        public CalculatorController(ICalculateRepo calculateRepo)
        {
            _calculateRepo=calculateRepo;
        }
       
        [HttpPost("Add")]
        public IActionResult Add(int a, int b)
        {

            var result = _calculateRepo.Add(a, b);
            return Ok(result);
        }
        [HttpPost("Substract")]
        public IActionResult Substract(int a, int b)
        {
            var result = _calculateRepo.Substract(a, b);
            return Ok(result);
        }
        [HttpPost("Divide")]
        public IActionResult Divide(int a, int b)
        {
            var result = _calculateRepo.Divide(a, b);
            return Ok(result);
        }
        [HttpPost("Multiply")]
        public IActionResult Multiply(int a, int b)
        {
            var result = _calculateRepo.Multiply(a, b);
            return Ok(result);
        }
    }
}
