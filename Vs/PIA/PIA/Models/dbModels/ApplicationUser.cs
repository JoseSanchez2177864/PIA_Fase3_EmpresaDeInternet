using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PIA.Models.dbModels
{
    public class ApplicationUser : IdentityUser<int>
    {

        [StringLength(50)]
        [Unicode(false)]
        public string Nombre { get; set; } = null!;

        [StringLength(100)]
        [Unicode(false)]
        public string Correo { get; set; } = null!;

        [Column("idRol")]
        public int IdRol { get; set; }

        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Opinione> Opiniones { get; set; } = new List<Opinione>();

        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
    }
}
