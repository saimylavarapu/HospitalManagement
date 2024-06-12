using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Table("Departnment")]
    public class Departnment
    {
        public Departnment()
        {
            Doctors = new List<Doctor>();
        }
        #region Properties
        [Key]
        
        public int PkDepartnemtId { get; set; }

        [Required]
      
        public string DepartnmentName { get; set; }

        public DateTime CretedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool IsActive { get; set; }  

        public bool IsDelete { get; set; }
        #endregion
        #region Associations
        [InverseProperty("Departnment")]
        public IList<Doctor> Doctors { get; set; } 
        #endregion

    }
}
