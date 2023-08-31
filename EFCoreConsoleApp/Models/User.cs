using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreConsoleApp.Models;

public partial class User
{
    public long Id { get; set; }

    public string? Name { get; set; }

    //public int CompanyId { get; set; }      // внешний ключ
    public int CompanyInfoKey { get; set; }

    [ForeignKey("CompanyInfoKey")]
    public Company? Company { get; set; }   // навигационное свойство
}
