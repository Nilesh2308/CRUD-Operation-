using System;
using System.Collections.Generic;

namespace HRManagement.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? Designation { get; set; }

    public int? Salary { get; set; }
}
