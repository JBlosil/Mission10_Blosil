using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class BowlingLeagueDatabaseContext : DbContext
    {
        public BowlingLeagueDatabaseContext()
        {
        }

        public BowlingLeagueDatabaseContext(DbContextOptions<BowlingLeagueDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bowler> Bowlers { get; set; }

        public virtual DbSet<Team> Teams { get; set; }
    }
}

