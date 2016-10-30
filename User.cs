﻿using System;
using Microsoft.
public class User : IdentityUser
{
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }

    [Required]
    public byte Level { get; set; }

    [Required]
    public DateTime JoinDate { get; set; }

}
