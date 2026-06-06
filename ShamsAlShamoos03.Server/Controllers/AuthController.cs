using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShamsAlShamoos03.Shared.Models;
using System.ComponentModel.DataAnnotations;

namespace ShamsAlShamoos03.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly SignInManager<ApplicationUsers> _signInManager;

    private readonly UserManager<ApplicationUsers> _userManager;

    public AuthController(
        SignInManager<ApplicationUsers> signInManager,
        UserManager<ApplicationUsers> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    [HttpGet("users")]
    public IActionResult GetUsers()
    {
        var users = _userManager.Users
            .Where(x => x.MelliCodeID != null)
            .Select(x => new UserVm
            {
                ID = x.UserName!,
                Title = x.FirstName! + " " + x.LastName! + " " + x.tblMelicodeID.ooDRJCOD.Title! + " " + x.tblMelicodeID.FST_NAM! + " " + x.tblMelicodeID.LST_NAM!,
                TitleEn1 = "/PersonelImage1/" + x.tblMelicodeID.MelliCode + ".png"
            })
            .OrderBy(x => x.Title)
            .ToList();

        return Ok(users);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginModel model)
    {
        try
        {
            var result = await _signInManager.PasswordSignInAsync(
                model.UserName,
                model.Password,
                true,
                false);

            if (result.Succeeded)
            {
                return Ok();
            }

            return Unauthorized("نام کاربری یا رمز عبور اشتباه است");
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.ToString());
        }
    }
}



public class LoginModel
{
    [Required(ErrorMessage = "نام کاربری الزامی است")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "رمز عبور الزامی است")]
    public string Password { get; set; }
}
