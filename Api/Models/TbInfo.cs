using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Api.Models;

[Table("tb_info")]
public partial class TbInfo
{
    [Key]
    [Column("id_afazer")]
    public int IdAfazer { get; set; }

    [Column("ds_afazer")]
    [StringLength(4000)]
    public string? DsAfazer { get; set; }
}
