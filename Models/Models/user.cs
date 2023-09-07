using Microsoft.Win32.SafeHandles;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    [Table("Users")]
    public class user
    {
        #region Constants
        public const int IDLENGTH = 100;
        public const int EMAILLENGTH = 200;
        public const int PHONELENGTH = 30;
        public const int NAMELENGTH = 200;
        public const int AVATARYRLLENGTH = 2000;
        public const int COMPANYLENTH = 200;
        public const int BIOLENGTH = 5000;
        #endregion

       
        #region Properties
        [Key]
        [Column(TypeName = "INT")]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(EMAILLENGTH)]
        public string? Email { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(NAMELENGTH)]
        public string? Name { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(PHONELENGTH)]
        public string? PhoneNumber { get; set; }

       
        [Column(TypeName = "VARCHAR")]
        [StringLength(AVATARYRLLENGTH)]
        public string? Avatar { get; set; }

        public DateTime CretedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(BIOLENGTH)]
        public string? Bio { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(BIOLENGTH)]
        public string? Comapany { get; set; }

       
        #endregion
    }

   

}