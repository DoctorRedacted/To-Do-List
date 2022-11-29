using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Api.Models;

[Table("tb_cadastro")]
public partial class TbCadastro
{
    [Key]
    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("nm_usuario")]
    [StringLength(20)]
    public string NmUsuario { get; set; } = null!;
}
