using Carros.Models;
using Dapper;
using System.Data.SqlClient;
using System.Globalization;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Carros.Services.CarroService
{
    public class CarroService : ICarroInterface
    {
        private readonly IConfiguration _configuration;
        private readonly string getConnection;
        private readonly CultureInfo cultureInfo = new CultureInfo("pt-BR");

        public CarroService(IConfiguration configuration)
        {
            _configuration = configuration;
            getConnection = _configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Carro>> GetAllCarros()
        {
            using (var con = new SqlConnection(getConnection))
            {
                var sql = "SELECT * FROM carros";
                return await con.QueryAsync<Carro>(sql);
            }
        }

        public async Task<Carro> GetCarroById(int carroId)
        {
            using (var con = new SqlConnection(getConnection))
            {
                var sql = "SELECT * FROM carros WHERE id = @id";
                return await con.QueryFirstOrDefaultAsync<Carro>(sql, new { id = carroId });
            }
        }

        public async Task<IEnumerable<Carro>> CreateCarro(Carro carro)
        {
            using (var con = new SqlConnection(getConnection))
            {
                var sql = "INSERT INTO carros (modelo, preco) VALUES (@Modelo, @Preco)";
                await con.ExecuteAsync(sql, carro);
                return await GetAllCarros();
            }
        }

        public async Task<IEnumerable<Carro>> UpdateCarro(Carro carro)
        {
            using (var con = new SqlConnection(getConnection))
            {
                var sql = "UPDATE carros SET modelo = @Modelo, preco = @Preco WHERE id = @Id";
                await con.ExecuteAsync(sql, carro);
                return await GetAllCarros();
            }
        }

        public async Task<IEnumerable<Carro>> DeleteCarro(int carroId)
        {
            using (var con = new SqlConnection(getConnection))
            {
                var sql = "DELETE FROM carros WHERE id = @id";
                await con.ExecuteAsync(sql, new { id = carroId });
                return await GetAllCarros();
            }
        }
    }
}
