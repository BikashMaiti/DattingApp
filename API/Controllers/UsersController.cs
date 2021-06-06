using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController: ControllerBase
    {
        public readonly DataContext _context;
        public UsersController(DataContext context){
            _context= context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> getUsers(){
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> getUser(int id){
            return await _context.Users.FindAsync(id);
        }
    }
}