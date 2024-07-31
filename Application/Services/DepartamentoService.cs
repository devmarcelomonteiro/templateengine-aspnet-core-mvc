using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interface;

namespace Application.Services
{
    public class DepartamentoService : IDepartamentoService
    {

        private readonly IDepartamentoRepository _departamentoRepository;

        public DepartamentoService(IDepartamentoRepository departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }

        public async Task<IEnumerable<DepartamentoDto>> GetAllAsync()
        {
            var departamentos = await _departamentoRepository.GetAllAsync();
            return departamentos.Select(p => new DepartamentoDto {Id = p.Id, Nome = p.Nome });
        }


        public async Task AddAsync(DepartamentoDto departamentoDto)
        {
            var departamento = new Departamento
            {
                Nome = departamentoDto.Nome
            };
            await _departamentoRepository.AddAsync(departamento);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DepartamentoDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(DepartamentoDto departamentoDto)
        {
            throw new NotImplementedException();
        }
    }
}
