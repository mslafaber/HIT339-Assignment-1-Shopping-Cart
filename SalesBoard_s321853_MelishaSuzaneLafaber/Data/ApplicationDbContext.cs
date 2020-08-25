using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalesBoard_s321853_MelishaSuzaneLafaber.Models;

namespace SalesBoard_s321853_MelishaSuzaneLafaber.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SalesBoard_s321853_MelishaSuzaneLafaber.Models.Items> Items { get; set; }
        public DbSet<SalesBoard_s321853_MelishaSuzaneLafaber.Models.Sales> Sales { get; set; }
        public DbSet<SalesBoard_s321853_MelishaSuzaneLafaber.Models.Cart> Cart { get; set; }
    }
}
