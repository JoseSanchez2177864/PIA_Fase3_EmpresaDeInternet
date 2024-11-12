using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PIA.Models.dbModels
{
    public class ApplicationUser
    {
        [Key]
        [Column("idUsuario")]
        public int IdUsuario { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string Nombre { get; set; } = null!;

        [StringLength(100)]
        [Unicode(false)]
        public string Correo { get; set; } = null!;

        [Column("idRol")]
        public int IdRol { get; set; }

        [ForeignKey("IdRol")]
        [InverseProperty("Usuarios")]
        public virtual Role IdRolNavigation { get; set; } = null!;

        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Opinione> Opiniones { get; set; } = new List<Opinione>();

        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
    }
}
