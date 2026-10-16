using Microsoft.EntityFrameworkCore;

namespace PagingSortingFilterationEx.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                 new Customer() {CustomerID=1,
                 CustomerName="Manish",
                 Address="Nigdi",
                 CreditLimit=4500,
                 EmailID="manish@hotmail.com"}
                );

            modelBuilder.Entity<Customer>().HasData(
                 new Customer()
                 {
                     CustomerID = 2,
                     CustomerName = "Akash",
                     Address = "Akurdi",
                     CreditLimit = 7500,
                     EmailID = "akash@hotmail.com"
                 }
                );


            modelBuilder.Entity<Customer>().HasData(
             new Customer()
             {
                 CustomerID =3,
                 CustomerName = "Amol",
                 Address = "Nigdi",
                 CreditLimit = 9500,
                 EmailID = "amol@hotmail.com"
             }
            );

            modelBuilder.Entity<Customer>().HasData(
             new Customer()
             {
                 CustomerID = 4,
                 CustomerName = "Ajit",
                 Address = "Nigdi",
                 CreditLimit = 56500,
                 EmailID = "Ajit@hotmail.com"
             }
            );

            modelBuilder.Entity<Customer>().HasData(
            new Customer()
            {
                CustomerID = 5,
                CustomerName = "Nilesh",
                Address = "Chinchwad",
                CreditLimit = 6500,
                EmailID = "nilesh@hotmail.com"
            }
           );

            modelBuilder.Entity<Customer>().HasData(
            new Customer()
            {
                CustomerID = 6,
                CustomerName = "Nitin",
                Address = "Nigdi",
                CreditLimit = 67500,
                EmailID = "nitin@hotmail.com"
            }
           );


            modelBuilder.Entity<Customer>().HasData(
            new Customer()
            {
                CustomerID = 7,
                CustomerName = "Rajesh",
                Address = "Pradhikaran",
                CreditLimit = 7800,
                EmailID = "rajesh@hotmail.com"
            }
           );

            modelBuilder.Entity<Customer>().HasData(
       new Customer()
       {
           CustomerID = 8,
           CustomerName = "Rakesh",
           Address = "Akurdi",
           CreditLimit = 9800,
           EmailID = "rakesh@hotmail.com"
       }
      );

            modelBuilder.Entity<Customer>().HasData(
       new Customer()
       {
           CustomerID = 9,
           CustomerName = "Ranjeet",
           Address = "Shivaji nagar",
           CreditLimit = 7800,
           EmailID = "Ranjeet@hotmail.com"
       }
      );

            modelBuilder.Entity<Customer>().HasData(
       new Customer()
       {
           CustomerID = 10,
           CustomerName = "Balaji",
           Address = "karvenagar",
           CreditLimit = 1800,
           EmailID = "Balaji@hotmail.com"
       }
      );

     }

        public DbSet<Customer> Customers { get; set; }

    }
}
