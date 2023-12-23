using Microsoft.AspNetCore.Mvc;
using DB_Layer1_Draftflex.Data;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace DB_Layer1_Draftflex.Users;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase 
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }
[HttpDelete("/")]
[Authorize]

// [HttpGet("/me")]
//     [Authorize]
//     public ActionResult<UserDto> CheckUser()
//     {
//         var user = HttpContext.User;
//         var id = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
//         var user = _userService.Users.FirstOrDefault(u => u.Sub == id);
//         if (user == null)
//             // weird way to do it, but if you wanted to use 404 as a way to tell the spa to start the integration process /shrug
//             return NotFound();
//     
//         return Ok(new UserDto { });
//     }
    
    [HttpPost("createUser")]
    public IActionResult PostUser(User user)
    {
        if (ModelState.IsValid)
        {
            var createdUser = _userService.CreateUser(user);
            return Ok(createdUser); // Returning the created user as an Ok response
        }
        return BadRequest(ModelState);
    }
}
    