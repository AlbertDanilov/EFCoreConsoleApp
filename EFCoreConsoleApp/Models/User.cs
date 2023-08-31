using System;
using System.Collections.Generic;

namespace EFCoreConsoleApp.Models;

public partial class User
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public int CompanyId { get; set; }      // внешний ключ
    public Company? Company { get; set; }   // навигационное свойство

    //public long Age { get; set; }
    //public string? Position { get; set; }
}
