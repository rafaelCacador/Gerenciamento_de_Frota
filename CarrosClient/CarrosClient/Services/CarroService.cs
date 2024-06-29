using CarrosClient.Models;
using CarrosClient.Services;
using System.Net.Http.Json;

public class CarroService : ICarroService
{
    private readonly HttpClient _httpClient;

    public CarroService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<Carro>> GetAllCarros()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<Carro>>("api/carro");
    }

    public async Task<Carro> GetCarroById(int id)
    {
        return await _httpClient.GetFromJsonAsync<Carro>($"api/carro/{id}");
    }

    public async Task<IEnumerable<Carro>> CreateCarro(Carro carro)
    {
        var response = await _httpClient.PostAsJsonAsync("api/carro", carro);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<IEnumerable<Carro>>();
    }

    public async Task<IEnumerable<Carro>> UpdateCarro(Carro carro)
    {
        var response = await _httpClient.PutAsJsonAsync("api/carro", carro);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<IEnumerable<Carro>>();
    }

    public async Task<IEnumerable<Carro>> DeleteCarro(int id)
    {
        var response = await _httpClient.DeleteAsync($"api/carro/{id}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<IEnumerable<Carro>>();
    }
}
