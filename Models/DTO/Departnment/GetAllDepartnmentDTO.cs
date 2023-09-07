using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO.Departnment
{
    public class GetAllDepartnmentDTO
    {
        public int PkDepartnemtId { get; set; }

        public string DepartnmentName { get; set; }

        public DateTime CretedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool IsActive { get; set; }

        public bool IsDelete { get; set; }

    }
}
