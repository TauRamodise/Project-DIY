#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Diy_Project.Models;

namespace Diy_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : ControllerBase
    {
        private readonly DiyContext _context;

        public ContractsController(DiyContext context) => _context = context;

        // GET: api/Contracts //NOT NEEDED: NO ADMIN USER
         [HttpGet]
         public async Task<ActionResult<IEnumerable<Contract>>> GetContracts()
            => await _context.Contracts.ToListAsync();

        // GET: api/Contracts/customer/5
        [HttpGet("customer/{id}")]
        public async Task<IEnumerable<Contract>> GetCustomerContractsById(int id)
            => await _context.Contracts.Where(contract => contract.CustomerID == id).ToListAsync();

        // GET: api/Contracts/provider/5
        [HttpGet("provider/{id}")]
        public async Task<IEnumerable<Contract>> GetProviderContractsById(int id)
        {
            return await _context.Contracts.Where(contract => contract.ProviderID == id).ToListAsync();
        }

        // GET: api/Contracts/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Contract), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Contract>> GetContract(int id)
        {
            var contract = await _context.Contracts.FindAsync(id);

            return contract == null ? NotFound() : Ok(contract);
        }

        // PUT: api/Contracts/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PutContract(int id, Contract contract)
        {
            if (id != contract.ID) return BadRequest();

            _context.Entry(contract).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContractExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Contract
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<Contract>> PostContract(Contract contract)
        {
            _context.Contracts.Add(contract);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContract", new { id = contract.ID }, contract);
        }

        private bool ContractExists(int id)
        {
            return _context.Contracts.Any(e => e.ID == id);
        }
    }
}
