using Cross;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interface
{
    public interface ICategoryRepository
    {
        Task<ResponseDto> GetAllCategory();
    }
}
