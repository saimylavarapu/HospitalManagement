using Models.DTO.Departnment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorys.DEPARTNMENT
{
   public interface IDepartnmentRepo
    {
        Task<bool> AddDepartnmetn(AddDepartnemtDTO adddepartment);
        Task<bool> DeleteDepartnment(int id);
        Task<bool> UpdateDepartnmetn(UpdateDepartnmentDTO updtatdep);
        Task<List<GetAllDepartnmentDTO>> GetAllDepartnment();
        Task<GetAllDepartnmentDTO> GetDepartnmentbyid(int id);
    }
}
