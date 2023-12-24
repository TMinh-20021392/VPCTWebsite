using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
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
            user.PhoneNumber = userInfo.PhoneNumber;
            user.Email = userInfo.Email;

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

        [HttpPost("changepassword")]
        public async Task<IActionResult> ChangePassword([FromForm] ChangePasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid input");
            }
            var user = await userManager.FindByIdAsync(model.Id);
            if (user == null)
            {
                return NotFound("User not found");
            }

            if (!string.IsNullOrEmpty(model.UserName))
            {
                user.UserName = model.UserName;
                var changeUserNameResult = await userManager.UpdateAsync(user);
                if (!changeUserNameResult.Succeeded)
                {
                    return BadRequest("Failed to change username");
                }
            }

            if (!string.IsNullOrEmpty(model.NewPassword) && !string.IsNullOrEmpty(model.CurrentPassword))
            {
                if (model.NewPassword != model.ConfirmNewPassword)
                {
                    return BadRequest("New password and confirm password do not match");
                }
                var changePasswordResult = await userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                if (changePasswordResult.Succeeded)
                {
                    return Ok("Username and password changed successfully");
                }
                else
                {
                    return BadRequest("Failed to change password");
                }
            }
            return Ok("Updated successfully");
        }
        public class ChangePasswordModel
        {
            [Required]
            public string Id { get; set; } = null!;
            public string? UserName { get; set; }
            public string? CurrentPassword { get; set; }
            public string? NewPassword { get; set; }
            public string? ConfirmNewPassword { get; set; }
        }

    }
}
