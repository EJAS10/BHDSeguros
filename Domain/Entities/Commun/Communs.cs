using BHDSeguros.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BHDSeguros.Domain.Entities.Commun
{
    public class Communs
    {
        public Communs()
        {
            Id = 0;
        }
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }
        [Required]
        public StatusEnum Status { get; set; } = StatusEnum.Activo;
        [Required]
        public DateTime DateCreation { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}
