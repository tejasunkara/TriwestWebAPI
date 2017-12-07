using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriwestWebAPI.Models;

namespace TriwestWebAPI.Demo
{
    public class CcnContext : DbContext
    {
        public CcnContext(DbContextOptions<CcnContext> options) : base(options)
        {
        }

        public DbSet<Veteran> Veterans { get; set; }      
        public DbSet<TrainingMessage> TrainingMessages { get; set; }
        public DbSet<Provider> Providers { get; set; }
    }
    }
