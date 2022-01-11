using maryamzafar_179.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace maryamzafar_179.DataDb
{
    public class storedb : DbContext
    {
        public storedb(DbContextOptions<storedb>options):base(options)
        {
            
        }
        public DbSet<OrderModel> orders { get; set; }
    }
}
