
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Amparix.data.Context
{
    public class AmparixContext : DbContext
    {
        public AmparixContext() : base("name=DefaultConnection")
        {
        }
        public DbSet<Ventas> Ventas { get; set; }
    }
    }

