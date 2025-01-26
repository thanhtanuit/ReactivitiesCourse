using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{    
    public class CourseController : BaseApiController
    {
        private readonly DataContext _context;
        public CourseController(DataContext context)
        {
            _context=context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Course>>> Get(){
            return await _context.Courses.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> Get(int id){
            return await _context.Courses.FirstAsync(a=>a.Id==id);
        }
    }
}