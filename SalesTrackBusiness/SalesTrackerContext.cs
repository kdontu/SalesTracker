using SalesTrackBusiness.Entities;

namespace SalesTrackBusiness
{
    using Microsoft.EntityFrameworkCore;

    public class SalesTrackerContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<SalesPerson> SalesPersons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=SalesTracker.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "City E Bike", Manufacturer = "Cikada", Description="Urban Cruising Bike", Style="Commuter", PurchasePrice=1100, SalePrice=1599, QtyOnHand=24, CommissionPercentage=12 },
                new Product { ProductId = 2, Name = "Touring E Bike", Manufacturer = "Cikada", Description="Long Distance Touring Bike", Style="Touring", PurchasePrice=1350, SalePrice=1999, QtyOnHand=15, CommissionPercentage=20 },
                new Product { ProductId = 3, Name = "Centris Folding", Manufacturer = "Buzz eBike", Description="Folding eBike", Style="Folding", PurchasePrice=1225, SalePrice=1850, QtyOnHand=9, CommissionPercentage=15},
                new Product { ProductId = 4, Name = "Beekeeper Cargo", Manufacturer = "Buzz eBike", Description="Beekeepers Cargo Rider", Style="Touring", PurchasePrice=1499, SalePrice=2200, QtyOnHand=10, CommissionPercentage=25 },
                new Product { ProductId = 5, Name = "Drone Moto Style", Manufacturer = "Buzz eBike", Description="Light as a Drone", Style="Commuter", PurchasePrice=1000, SalePrice=1350, QtyOnHand=29, CommissionPercentage=20},
                new Product { ProductId = 6, Name = "Cerena 2 Commute", Manufacturer = "Buzz eBike", Description="Good for Commuters", Style="Commuter", PurchasePrice=1150, SalePrice=1500, QtyOnHand=17, CommissionPercentage=15},
                new Product { ProductId = 7, Name = "Sol X Comfort", Manufacturer = "Blix", Description= "Easy Fun Riding", Style="Comfort", PurchasePrice=1100, SalePrice=1650, QtyOnHand=16, CommissionPercentage=18},
                new Product { ProductId = 8, Name = "Vika X Folding", Manufacturer = "Blix", Description="Most Practical Folding", Style="Folding", PurchasePrice=1250, SalePrice=1750, QtyOnHand=23, CommissionPercentage=20},
                new Product { ProductId = 9, Name = "Packa Genie Cargo", Manufacturer = "Blix", Description="Pack It All", Style="Touring", PurchasePrice=1600, SalePrice=2350, QtyOnHand=15, CommissionPercentage=30 });

            modelBuilder.Entity<SalesPerson>().HasData(
                new SalesPerson { SalesPersonId = 1, FirstName = "Thomas", LastName = "Morgan", Address = "555 Brown Avenue, Sacramento, CA 94203", Phone = "123-345-1234", StartDate = new DateTime(2022,02,15), TerminationDate = new DateTime(2024, 02, 15), Manager = "Mike Brown" },
                new SalesPerson { SalesPersonId = 2, FirstName = "Jane", LastName = "Jackson", Address = "221 North Avenue, Atlanta, GA 30005", Phone = "443-123-5678", StartDate = new DateTime(2020, 09, 30), TerminationDate = new DateTime(2023, 09, 30), Manager = "Mike Brown" });

            modelBuilder.Entity<Discount>().HasData(
                new Discount { DiscountId = 1, ProductId = 2, BeginDate = new DateTime(2024,1,1), EndDate = new DateTime(2024, 12, 31), DiscountPercentage = 20 },
                new Discount { DiscountId = 2, ProductId = 5, BeginDate = new DateTime(2023, 8, 15), EndDate = new DateTime(2025, 10, 31), DiscountPercentage = 10 });

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, FirstName = "John", LastName = "Max", Address = "123 Peachtree Pkwy, Atlanta, GA 30021", Phone = "124-125-9999", StartDate = new DateTime(2024,5,21) },
                new Customer { CustomerId = 2, FirstName = "Tiffany", LastName = "Lime", Address = "999 South Parson Rd, Duluth, GA 30022", Phone = "443-123-5678", StartDate = new DateTime(2024,2,19) });

            modelBuilder.Entity<Sales>().HasData(
                new Sales { SalesId = 1, ProductId = 3, SalesDate = new DateTime(2024, 12, 28), CustomerId = 1, SalesPersonId = 2 },
                new Sales { SalesId = 2, ProductId = 2, SalesDate = new DateTime(2024, 03, 15), CustomerId = 2, SalesPersonId = 1 });
        }
    }
}
