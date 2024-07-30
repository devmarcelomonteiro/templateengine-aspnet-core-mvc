using Application.DTOs;

namespace Application.Interfaces
{
    public interface IDepartamentoService
    {
        Task<IEnumerable<DepartamentoDto>> GetAllAsync();
        Task<DepartamentoDto> GetByIdAsync(int id);
        Task AddAsync(DepartamentoDto departamentoDto);
        Task UpdateAsync(DepartamentoDto departamentoDto);
        Task DeleteAsync(int id);
    }
}
