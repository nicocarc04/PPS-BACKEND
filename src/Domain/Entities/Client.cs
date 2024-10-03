﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Infrastructure.TempModels;

public partial class Client
{
    public string Dniclient { get; set; } = null!;

    public string Typememberships { get; set; } = null!;

    public DateTime Startdatemembership { get; set; }

    public string Statusmembership { get; set; } = null!;

    public DateOnly Birthdate { get; set; }

    public string Phonenumber { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public int Iduser { get; set; }

    public virtual User IduserNavigation { get; set; } = null!;

    public virtual ICollection<Routine> Routines { get; set; } = new List<Routine>();

    public virtual ICollection<Shiftsclient> Shiftsclients { get; set; } = new List<Shiftsclient>();

    public virtual Membership TypemembershipsNavigation { get; set; } = null!;
}
