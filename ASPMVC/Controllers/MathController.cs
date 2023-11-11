using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASPMVC.Controllers
{
    public class MathController : Controller
    {
        private readonly ILogger<MathController> _logger;

        public MathController(ILogger<MathController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.LogInformation("La liste des URLs disponibles est : '/math/table/#', '/math/#/table', '/math/estpair/#', '/math/multiplication?nb1=#&nb2=#'");
            return Ok("La liste des URLs disponibles est : '/math/table/#', '/math/#/table', '/math/estpair/#', '/math/multiplication?nb1=#&nb2=#'");
        }

        [Route("Math/Table/{number?}")]
        [Route("Math/{number?}/Table")]

        public IActionResult Table(string number) {
            int nb;

            bool test = int.TryParse(number, out nb);
            if (test)
            {
                for (int i = 0; i < nb; i++)
                {
                   _logger.LogInformation($"{i} x {nb} = {i * nb}");
                    
                }
                return Ok();
            } else
            {
                return BadRequest("Mauvaise valeur");
            }

        }

        public IActionResult EstPair(string number)
        {
            int nb;

            bool test = int.TryParse(number, out nb);
            if (test)
            {
                string  response = (nb % 2 == 0) ? "Pair" : "impair";
                    
                 _logger.LogInformation($"{response}");

                
                return Ok();
            }
            else
            {
                return BadRequest("Mauvaise valeur");
            }
        }

        public IActionResult Multiplication(string number1, string number2)
        {
            int nb1;
            int nb2;

            bool test1 = int.TryParse(number1, out nb1);
            bool test2 = int.TryParse(number2, out nb2);

            if (test1 && test2)
            {

                _logger.LogInformation($"{nb1} x {nb2} = {nb1*nb2}");
                return Ok();
            }
            else
            {
                return BadRequest("Mauvaise valeur");
            }
        }

    }
}
