using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ScavengerHunt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<Quest> Quests { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<QuestItem> QuestItems { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}