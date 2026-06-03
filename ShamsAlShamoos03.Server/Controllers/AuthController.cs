using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShamsAlShamoos03.Shared.Entities;
using ShamsAlShamoos03.Shared.Models;

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
                Title = x.FirstName! + " " + x.LastName! + " " + x.tblMelicodeID.ooDRJCOD.Title! + " " + x.tblMelicodeID.FST_NAM! + " " +  x.tblMelicodeID.LST_NAM!,
                TitleEn1 = "/PersonelImage1/" + x.tblMelicodeID.MelliCode + ".png"
            })
            .OrderBy(x => x.Title)
            .ToList();

        return Ok(users);
    }

[HttpPost("login")]
    public async Task<IActionResult> Login(LoginModel model)
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
}


public class LoginModel
{
    public string UserName { get; set; } = "";

    public string Password { get; set; } = "";
}

//                    var result = await _signInManager.PasswordSignInAsync(user.UserName, Password, isPersistent: false, lockoutOnFailure: false);

//                    if (result.Succeeded && user.IsActive==1)
//                    {
//                        TempData["ShowWelcome"] = "true"; // 👈 این خط رو اضافه کن

//                        //TempData["SuccessMessage"] = " کاربر گرامی " + user.FirstName + " " + user.LastName + " ورود شما با موفقیت انجام شد! ";

//                        if (!string.IsNullOrEmpty(ReturnUrl) && Url.IsLocalUrl(ReturnUrl))
//                        {
//                            return LocalRedirect(ReturnUrl);  // ✅ برگرد به صفحه‌ای که کاربر اول می‌خواست بره
//                        }
//                        return Redirect("~/Landing");  // توجه کن Redirect نه RedirectToPage
//                    }

//                    if (result.Succeeded && user.IsActive == 1)
//{
//    //TempData["SuccessMessage"] = " کاربر گرامی " + user.FirstName + " " + user.LastName + " ورود شما با موفقیت انجام شد! ";

//    return Redirect("~/Landing");  // توجه کن Redirect نه RedirectToPage

//}
//else
//{
//    ErrorMessage = "حساب کاربری غیرفعال است یا نام کاربری یا رمز عبور اشتباه وارد شده است.";
//}