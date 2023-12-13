using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.Identity;

namespace VPCTWebsiteAPI.Controllers.IdentityController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager) : ControllerBase
    {
        [HttpGet("GetUsersWithRoles")]
        public async Task<IActionResult> GetUsersWithRolesAsync()
        {
            var users = await userManager.Users.ToListAsync(); // Assuming userManager is of type UserManager<TUser>

            var usersWithRoles = new List<object>();

            foreach (var user in users)
            {
                var roles = await userManager.GetRolesAsync(user);
                var userWithRoles = new
                {
                    user.Id,
                    user.UserName,
                    user.FullName,
                    user.PhoneNumber,
                    user.Address,
                    user.Email,
                    Roles = roles
                };
                usersWithRoles.Add(userWithRoles);
            }

            return Ok(usersWithRoles);
        }

        [HttpPost("AssignRole")]
        public async Task<IActionResult> AssignRole([FromBody] RoleAssignmentModel model)
        {
            var user =  await userManager.FindByIdAsync(model.UserId);
            if (user == null)
            {
                return NotFound("User not found");
            }

            var roleExists =  await roleManager.RoleExistsAsync(model.Role);
            if (!roleExists)
            {
                return BadRequest("Role does not exist");
            }

            var isInRole =  await userManager.IsInRoleAsync(user, model.Role);
            if (model.Selected && !isInRole)
            {
                 await userManager.AddToRoleAsync(user, model.Role);
            }
            else if (!model.Selected && isInRole)
            {
                 await userManager.RemoveFromRoleAsync(user, model.Role);
            }

            return Ok("Role assignment updated successfully");
        }
    }
}
