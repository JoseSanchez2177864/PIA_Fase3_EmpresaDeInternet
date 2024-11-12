using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PIA.Models.dbModels;

public partial class Role
{
    [Key]
    [Column("idRol")]
    public int IdRol { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string NombreRol { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;

    [InverseProperty("IdRolNavigation")]
    public virtual ICollection<ApplicationUser> Usuarios { get; set; } = new List<ApplicationUser>();
}
