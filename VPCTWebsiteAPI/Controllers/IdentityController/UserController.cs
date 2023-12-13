using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VPCT.Core.Models.Identity;
using VPCTWebsiteAPI.Service;

namespace VPCTWebsiteAPI.Controllers.IdentityController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(UserManager<ApplicationUser> userManager, IImageService imageService) : ControllerBase
    {
        [HttpPut("update-user-info")]
        public async Task<IActionResult> UpdateUserInfo([FromForm] ApplicationUser userInfo)
        {
            if (userInfo.ImageFile != null && userInfo.ImageFile.Length > 0)
            {
                if (!string.IsNullOrEmpty(userInfo.ImageName))
                {
                    imageService.DeleteImage(userInfo.ImageName);
                }
                userInfo.ImageName = await imageService.SaveImage(userInfo.ImageFile);
            }

            var user = await userManager.FindByIdAsync(userInfo.Id);
            if (user == null)
            {
                return NotFound("User not found");
            }

            user.FullName = userInfo.FullName;
            user.Address = userInfo.Address;
            user.Description = userInfo.Description;
            user.ImageName = userInfo.ImageName;

            var result = await userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return Ok("User information updated successfully");
            }
            else
            {
                return BadRequest("Failed to update user information");
            }
        }

        [HttpGet("account-details/{userId}")]
        public async Task<IActionResult> GetAccountDetails(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound("User not found");
            }
            user.ImageSrc = $"{Request.Scheme}://{Request.Host}{Request.PathBase}/Images/{user.ImageName}";
            return Ok(user);
        }
    }
}
