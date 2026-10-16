using PagingSortingFilterationEx.Models;

namespace PagingSortingFilterationEx.Repositories
{
    public interface ICustomer
    {
        Task<List<Customer>> GetAll();
        Task<Customer> GetByID(Int64 id);
        Task Create(Customer rec);
        Task Update(Customer rec);
        Task Delete(Int64 id);
    }
}
