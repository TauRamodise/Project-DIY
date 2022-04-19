using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_DIY.Data;
using Project_DIY.Models;

namespace Project_DIY.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContractController : ControllerBase
    {

        private readonly DiyDbContext _context;

        public ContractController(DiyDbContext context) => _context = context;

        [HttpGet(Name = "GetAllContracts")]
        public async Task<IEnumerable<Contract>> GetAllContracts()
            => await _context.Contracts.ToListAsync();

        [HttpGet("customer/{id}")]
        public async Task<IEnumerable<Contract>> GetCustomerContractsById(int id)
            => await _context.Contracts.Where(contract => contract.CustomerId == id).ToListAsync();

        [HttpGet("provider/{id}")]
        public async Task<IEnumerable<Contract>> GetProviderContractsById(int id)
        {
            return await _context.Contracts.Where(contract => contract.ProviderId == id).ToListAsync();
        }

        [HttpGet("id")]
        [ProducesResponseType(typeof(Contract), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetContractById(int id)
        {
            var contract = await _context.Contracts.FindAsync(id);
            return contract == null ? NotFound() : Ok(contract);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> NewContract(Contract contract)
        {
            await _context.Contracts.AddAsync(contract);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetContractById), new {id = contract.Id}, contract);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateContract(int id, Contract contract)
        {
            if (id != contract.Id) return BadRequest();

            _context.Entry(contract).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}