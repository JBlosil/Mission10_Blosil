using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Models;

public partial class Team
{
    [Key]
    public int TeamID { get; set; }

    public string TeamName { get; set; }
}
