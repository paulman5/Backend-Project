using Microsoft.AspNetCore.Mvc;
using DB_Layer1_Draftflex.Data;
using Microsoft.EntityFrameworkCore;

namespace DB_Layer1_Draftflex.Users;

    public class UserService
    {
        private readonly DraftflexDataContext _context;

        public UserService(DraftflexDataContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> CreateUser(User user)
        {
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
            if (existingUser != null)
            {
                return new OkObjectResult(existingUser);
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return new OkObjectResult(user);
        }
    }


