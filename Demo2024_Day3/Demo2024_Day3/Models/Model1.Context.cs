﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo2024_Day3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Demo2024Entities : DbContext
    {
        public Demo2024Entities()
            : base("name=Demo2024Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<order> order { get; set; }
        public virtual DbSet<orderpersonlist> orderpersonlist { get; set; }
        public virtual DbSet<person> person { get; set; }
        public virtual DbSet<shift> shift { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<userlist> userlist { get; set; }
        public virtual DbSet<userrole> userrole { get; set; }
    }
}
