using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Travx.Models;

namespace Travx.API.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
            
        }
        
        public DbSet<Job> Jobs {get; set; }
        public DbSet<JobCalegory> JobCalegories { get; set; }
    }
}