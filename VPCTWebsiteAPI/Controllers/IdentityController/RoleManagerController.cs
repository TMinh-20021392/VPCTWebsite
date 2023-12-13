using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace VPCTWebsiteAPI.Controllers.IdentityController
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleManagerController(RoleManager<IdentityRole> roleManager) : ControllerBase
    {
        [HttpGet("GetRoles")]
        public IActionResult GetRoles()
        {
            var roles = roleManager.Roles.ToList();
            return Ok(roles);
        }

        [HttpPost("AddRole")]
        public async Task<IActionResult> AddRole([FromBody] string roleName)
        {
            var role = new IdentityRole(roleName);
            var result =  await roleManager.CreateAsync(role);

            if (result.Succeeded)
            {
                return Ok("Role added successfully");
            }
            else
            {
                return BadRequest("Failed to add role");
            }
        }

    }
}
