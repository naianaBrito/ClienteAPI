﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ClienteAPI.Models
{
    public class MeuContext : DbContext
    {
        public MeuContext() : base("name=MeuContext")
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}