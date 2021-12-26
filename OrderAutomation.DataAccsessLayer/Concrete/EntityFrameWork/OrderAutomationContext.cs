using OrderAutomation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderAutomation.DataAccsessLayer.Concrete.EntityFrameWork
{
    public class OrderAutomationContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cash> Cashes { get; set; }
        public DbSet<Check> Checks { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<CustomerChoose> CustomerChooses { get; set; }
        public DbSet<LogIn> LogIns { get; set; }

    }
}
