using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Table("Doctor")]
    public  class Doctor
    {
        #region
        [Key]
        public int PkDoctorId { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        public string DoctorName { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string Specialization { get; set; }

        [Required]
        [Column(TypeName ="INT")]
        public int PhoneNumber { get; set; }

        public DateTime CretedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool IsActive { get; set; }

        public bool IsDelete { get; set; }

        [ForeignKey("FkDepartmentId")]
        public Departnment Department { get; set; }
        public int FkDepartmentId { get; set; }
        #endregion
    }
}
