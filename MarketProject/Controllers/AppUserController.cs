using MarketProject.Dtos.AppUserDtos;
using MarketProject.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarketProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AppUserController : ControllerBase
{
    private readonly IAppUserService _appUserService;

    public AppUserController(IAppUserService appUserService)
    {
        _appUserService = appUserService;
    }
    [HttpPost]
    public async Task<IActionResult> Register(RegisterAppUserDto registerDto)
    {
        var result = await _appUserService.Register(registerDto);
        if (result == true)
        {
            return Ok("You have successfully registered");
        }
        return BadRequest("Password and confirm password are not matched");
    }
    [HttpGet]
    public async Task<IActionResult> Login(string username, string password)
    {
        LoginAppUserDto loginDto = new() { Username = username, Password = password };
        var result = await _appUserService.Login(loginDto);
        if (result == null)
            return BadRequest("Username or password is wrong");
        return Ok(result);
    }
    [HttpPut("ForgetPassword")]
    public async Task<IActionResult> ForgetPassword(ForgetAppUserPasswordDto forgetPasswordDto)
    {
        var result = await _appUserService.ForgetPasswordAsync(forgetPasswordDto);
        if (result == false)
            return BadRequest("Something went wrong");

        return Ok("Password successfully changed");
    }
    [HttpPut]
    public async Task<IActionResult> ChangePassword(ChangeAppUserPasswordDto changePasswordDto)
    {
        var result = await _appUserService.ChangePasswordAsync(changePasswordDto);
        if (result == false)
            return BadRequest("Something went wrong");
        return Ok("Password successfully changed");
    }
}


