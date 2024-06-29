using System.Collections.Generic;
using System.Threading.Tasks;
using CarrosClient.Models;

namespace CarrosClient.Services
{
    public interface ICarroService
    {
        Task<IEnumerable<Carro>> GetAllCarros();
        Task<Carro> GetCarroById(int id);
        Task<IEnumerable<Carro>> CreateCarro(Carro carro);
        Task<IEnumerable<Carro>> UpdateCarro(Carro carro);
        Task<IEnumerable<Carro>> DeleteCarro(int id);
    }
}
