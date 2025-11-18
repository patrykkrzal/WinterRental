using Microsoft.EntityFrameworkCore;
using WinterRental.Models;
namespace WinterRental.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Equipment> Equipment { get;set; }
public DbSet<Order> Orders {get;set; }
public DbSet<RentalInfo> RentalInfo {get;set; }
public DbSet<User> Users{ get; set; }
public DbSet<Warehouse> Warehouse{ get; set; }
public DbSet<Worker> Workers{ get; set; }
    
        }
    }




