//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sessia_2_PM_03
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AbonentsDBEntities : DbContext
    {
        private static AbonentsDBEntities _context;
        public AbonentsDBEntities()
            : base("name=AbonentsDBEntities")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public static AbonentsDBEntities GetContext()
        {
            if (_context == null)
                _context = new AbonentsDBEntities();

            return _context;
        }
        
    
        public virtual DbSet<abonents> abonents { get; set; }
    }
}
