using Microsoft.AspNetCore.Mvc;
using DB_Layer1_Draftflex.Data;

namespace DB_Layer1_Draftflex.Users;

    public class UserService
    {
        private readonly DraftflexDataContext _context;

        public UserService(DraftflexDataContext context)
        {
            _context = context;
        }
        
        public IActionResult CreateUser(User user)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.Email == user.Email);
            if (existingUser != null)
            {
                return new OkObjectResult(existingUser);
            }

            _context.Users.Add(user);
            _context.SaveChanges();
            return new OkObjectResult(user);
        }
    }


