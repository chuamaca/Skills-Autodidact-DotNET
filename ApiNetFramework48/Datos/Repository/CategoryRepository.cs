using ApiNET.Model;
using Cross;
using Datos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IRepository<Categorias> _categoriasRepository;
        public CategoryRepository(IRepository<Categorias> categoriasRepository)
        {
            _categoriasRepository = categoriasRepository;
        }

        public async Task<ResponseDto> GetAllCategory()
        {
            var responseDto = ResponseDto.Create(new List<Categorias>());
            var result = await _categoriasRepository.GetAllAsync();
            responseDto.Data = result;
            return responseDto;
        }
    }
}
