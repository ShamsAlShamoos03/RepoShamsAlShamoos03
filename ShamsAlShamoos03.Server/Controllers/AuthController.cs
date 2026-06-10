using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShamsAlShamoos03.Infrastructure.Persistence.Contexts;
using ShamsAlShamoos03.Shared.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace ShamsAlShamoos03.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly SignInManager<ApplicationUsers> _signInManager;
    private readonly UserManager<ApplicationUsers> _userManager;
    private readonly ApplicationDbContext _context;

    public AuthController(
        SignInManager<ApplicationUsers> signInManager,
        UserManager<ApplicationUsers> userManager,
        ApplicationDbContext context)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _context = context;
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

    [HttpGet("current-user")]
    public async Task<IActionResult> CurrentUser()
    {
        // برگرداندن اطلاعات کاربر جاری
        try
        {
            var userId = _userManager.GetUserId(User);
            var user = await _context.Users
                .Include(x => x.tblMelicodeID)
                    .ThenInclude(x => x.ooDRJCOD)
                .FirstOrDefaultAsync(x => x.Id == userId);

            if (user == null)
            {
                return Unauthorized();
            }

            var currentUser = new Currentuser
            {
                ID = user.UserName ?? "",
                FullName = $"{user.tblMelicodeID?.ooDRJCOD?.Title ?? ""} {user.tblMelicodeID?.FST_NAM ?? ""} {user.tblMelicodeID?.LST_NAM ?? ""}",
                RoleName = $"{user.FirstName ?? ""} {user.LastName ?? ""}",
                UserImage = user.tblMelicodeID != null
                          ? "/PersonelImage1/" + user.tblMelicodeID.MelliCode + ".png"
                          : "/PersonelImage1/" + ".png"
            };

            return Ok(currentUser);
        }
        catch (Exception ex)
        {
            // نمایش دقیق خطا در کنسول یا لاگ سرور
            Console.WriteLine(ex);
            return StatusCode(500, ex.Message);
        }

        
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
