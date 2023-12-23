using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody] UserCreationModel model)
        {
            var user = new ApplicationUser
            {
                UserName = model.UserName,
                FullName = model.FullName,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
                Email = model.Email
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return Ok("User created successfully");
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpPut("UpdateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UserUpdateModel model)
        {
            var user = await userManager.FindByIdAsync(model.UserId);
            if (user == null)
            {
                return NotFound("User not found");
            }

            user.UserName = model.UserName;
            user.FullName = model.FullName;
            user.PhoneNumber = model.PhoneNumber;
            user.Address = model.Address;
            user.Email = model.Email;

            var result = await userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return Ok("User updated successfully");
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpDelete("DeleteUser/{userId}")]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound("User not found");
            }

            var result = await userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                return Ok("User deleted successfully");
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

    }
    public class UserCreationModel
    {
        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        public string FullName { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;

        public string? Address { get; set; }

        public string? Description { get; set; }

        public string? ImageName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
    }

    public class UserUpdateModel
    {
        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        public string FullName { get; set; } = null!;

        public string? Address { get; set; }

        public string? Description { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        public string? ImageName { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
    }


}
