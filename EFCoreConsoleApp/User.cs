using System;
using System.Collections.Generic;

namespace EFCoreConsoleApp;

public partial class User
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long Age { get; set; }
    public string? Position { get; set; }
}
