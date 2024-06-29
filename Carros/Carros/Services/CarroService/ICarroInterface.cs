using Carros.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Carros.Services.CarroService
{
    public interface ICarroInterface
    {
        Task<IEnumerable<Carro>> GetAllCarros();
        Task<Carro> GetCarroById(int carroId);
        Task<IEnumerable<Carro>> CreateCarro(Carro carro);
        Task<IEnumerable<Carro>> UpdateCarro(Carro carro);
        Task<IEnumerable<Carro>> DeleteCarro(int carroId);
    }
}
