﻿using Api.Data;
using Api.Models.DTO.Request;
using Api.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpotCategotyController : ControllerBase
    {
        private readonly AppDbContext _context;
        public SpotCategotyController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSpotCategory([FromForm] SpotCategotyRequestDto request)
        {
            var spotCategory = new SpotCategory
            {
                SpotId = request.SpotId,
                Name = request.Name,
                Description = request.Description,
            };

            await _context.SpotCategories.AddAsync(spotCategory);
            await _context.SaveChangesAsync();

            return Ok(spotCategory);
        }
    }
}
