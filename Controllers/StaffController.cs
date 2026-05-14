using AutoMapper;
using FilmRental.API.Data;
using FilmRental.API.DTOs;
using FilmRental.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilmRental.API.Controllers
{
    [ApiController]
    [Route("api/staff")]
    public class StaffController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public StaffController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // POST: /api/staff/post
        [HttpPost("post")]
        public async Task<IActionResult> AddStaff([FromBody] StaffCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var staff = _mapper.Map<Staff>(dto);
            _context.Staffs.Add(staff);
            await _context.SaveChangesAsync();

            return StatusCode(201, "Record Created Successfully");
        }

        // GET: /api/staff/get
        [HttpGet("get")]
        public async Task<IActionResult> GetStaffs()
        {
            var staffs = await _context.Staffs.ToListAsync();
            var result = _mapper.Map<IEnumerable<StaffReadDto>>(staffs);
            return Ok(result);
        }
        
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            var staff = await _context.Staffs.FindAsync(id);

            if (staff == null)
                return NotFound($"Staff with Id = {id} not found");

            _context.Staffs.Remove(staff);
            await _context.SaveChangesAsync();

            return Ok("Record Deleted Successfully");
        }
    }
}