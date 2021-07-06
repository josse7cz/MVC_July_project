using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_July_project.Models;

namespace MVC_July_project.Data
{
    public class MVC_July_projectContext : DbContext
    {
        public MVC_July_projectContext (DbContextOptions<MVC_July_projectContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_July_project.Models.Movie> Movie { get; set; }
    }
}
