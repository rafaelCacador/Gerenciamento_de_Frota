using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Carros.Services.CarroService;
using Carros.Models;

namespace Carros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly ICarroInterface _carroService;

        public CarroController(ICarroInterface carroService)
        {
            _carroService = carroService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCarros()
        {
            var carros = await _carroService.GetAllCarros();
            return Ok(carros);
        }

        [HttpGet("{carroId}")]
        public async Task<IActionResult> GetCarroById(int carroId)
        {
            if (carroId <= 0)
            {
                return BadRequest("Invalid carroId.");
            }

            var carro = await _carroService.GetCarroById(carroId);
            if (carro == null)
            {
                return NotFound();
            }

            return Ok(carro);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCarro([FromBody] Carro carro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var carros = await _carroService.CreateCarro(carro);
            return Ok(carros);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCarro([FromBody] Carro carro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var carros = await _carroService.UpdateCarro(carro);
            return Ok(carros);
        }

        [HttpDelete("{carroId}")]
        public async Task<IActionResult> DeleteCarro(int carroId)
        {
            if (carroId <= 0)
            {
                return BadRequest("Invalid carroId.");
            }

            var carros = await _carroService.DeleteCarro(carroId);
            return Ok(carros);
        }
    }
}
