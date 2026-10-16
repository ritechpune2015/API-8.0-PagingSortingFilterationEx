using PagingSortingFilterationEx.Models;

namespace PagingSortingFilterationEx.Repositories
{
    public class CustomerRepo : ICustomer
    {
        CompanyContext cc;
        public CustomerRepo(CompanyContext cc)
        {
            this.cc = cc;
        }
        public async Task Create(Customer rec)
        {
            await this.cc.Customers.AddAsync(rec);
            await this.cc.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var rec =await this.cc.Customers.FindAsync(id);
            this.cc.Customers.Remove(rec);
            await this.cc.SaveChangesAsync();
        }

        public async Task<List<Customer>> GetAll()
        {
            return this.cc.Customers.ToList();
        }

        public async Task<Customer> GetByID(long id)
        {
            return await this.cc.Customers.FindAsync(id);
        }

        public async Task Update(Customer rec)
        {
            this.cc.Customers.Update(rec);
            await this.cc.SaveChangesAsync();
        }
    }
}
