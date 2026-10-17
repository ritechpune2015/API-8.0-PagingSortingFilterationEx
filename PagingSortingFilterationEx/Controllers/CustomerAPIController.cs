using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PagingSortingFilterationEx.Models;
using PagingSortingFilterationEx.Repositories;
using System.Formats.Asn1;
using System.Threading.Tasks;

namespace PagingSortingFilterationEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAPIController : ControllerBase
    {
        ICustomer repo;
        public CustomerAPIController(ICustomer repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers([FromQuery]QueryObject obj)
        {
            return Ok( await this.repo.GetAll(obj));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Int64 id)
        {
            return Ok(await(this.repo.GetByID(id)));
        }


        [HttpPost]
        public async Task<IActionResult> Create(Customer rec)
        {
            await this.repo.Create(rec);
            return Ok("Customer Created!");
        }


        [HttpPut]
        public async Task<IActionResult> Update(Customer rec)
        {
            await this.repo.Update(rec);
            return Ok("Customer Updated!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Int64 id)
        {
            await this.repo.Delete(id);
            return Ok("Customer Deleted!");
        }
    }
}
