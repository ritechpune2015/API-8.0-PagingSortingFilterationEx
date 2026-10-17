using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Customer>> GetAll(QueryObject obj)
        {
            var customers = this.cc.Customers.AsQueryable();

            if (obj.MinimumCreditLimit != null)
            {
                customers = customers.Where(p => p.CreditLimit>obj.MinimumCreditLimit);
            }
            if (obj.MaximumCreditLimit != null)
            {
                customers = customers.Where(p=>p.CreditLimit < obj.MaximumCreditLimit);
            }

            if (obj.SortBy != null)
            {
                if (obj.SortBy.Equals("CustomerName", StringComparison.OrdinalIgnoreCase))
                {
                    if (obj.IsDescending)
                    {
                        customers = customers.OrderByDescending(p => p.CustomerName);
                    }
                    else
                    {
                        customers = customers.OrderBy(p => p.CustomerName);
                    }

                }
                else if (obj.SortBy.Equals("CreditLimit", StringComparison.OrdinalIgnoreCase))
                {
                    if (obj.IsDescending)
                    {
                        customers = customers.OrderByDescending(p => p.CreditLimit);
                    }
                    else
                    {
                        customers = customers.OrderBy(p => p.CreditLimit);
                    }
                }

            }

            var skipnumber = (obj.PageNumber - 1) * obj.PageSize;
            return await customers.Skip(skipnumber).Take(obj.PageSize).ToListAsync();
     
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
