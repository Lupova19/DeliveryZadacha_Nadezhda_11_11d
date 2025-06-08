using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryZadacha.Models
{
    public class DeliveryContext : DbContext
    {
        public DeliveryContext() : base("DeliveryContext")
        {

        }
        public DbSet<DishType> DishTypes { get; set; }
        public DbSet<Dish> Dishes { get; set; }
    }
}
