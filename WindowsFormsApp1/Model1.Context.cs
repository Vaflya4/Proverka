//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_RemontEntities1 : DbContext
    {
        public BD_RemontEntities1()
            : base("name=BD_RemontEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Perfomance> Perfomance { get; set; }
        public virtual DbSet<Status_order> Status_order { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
