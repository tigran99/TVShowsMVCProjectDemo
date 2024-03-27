using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TVShowProject.Models;

namespace TVShowProject.Data
{
    public class TVShowContext : DbContext
    {
        public TVShowContext (DbContextOptions<TVShowContext> options)
            : base(options)
        {
        }

        public DbSet<TVShowProject.Models.TvShow> TvShow { get; set; } = default!;
    }
}
