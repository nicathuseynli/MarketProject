using MarketProject.Datas.Entities;
using MarketProject.Dtos.AppUserDtos;
using MarketProject.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace MarketProject.Services.Implementations;
public class AppUserService : IAppUserService
{
    private readonly UserManager<AppUser> _userManager;

    public AppUserService(UserManager<AppUser> userManager)
    {
        _userManager = userManager;

    }

    public async Task<bool> ChangePasswordAsync(ChangeAppUserPasswordDto changePasswordDto)
    {
        var user = await _userManager.FindByEmailAsync(changePasswordDto.Email);
        if (user == null)
            return false;
        var result = await _userManager.ChangePasswordAsync(user, changePasswordDto.CurrentPassword, changePasswordDto.Password);
        if (!result.Succeeded)
        {
            return false;
        }
        return true;
    }

    public async Task<bool> ForgetPasswordAsync(ForgetAppUserPasswordDto forgetPasswordDto)
    {
        var user = await _userManager.FindByEmailAsync(forgetPasswordDto.Email);
        if (user == null)
        {
            return false;
        }
        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        var result = await _userManager.ResetPasswordAsync(user, token, forgetPasswordDto.Password);
        if (!result.Succeeded)
        {
            return false;
        }
        return true;
    }

    public async Task<AppUser> Login(LoginAppUserDto loginDto)
    {
        var user = await _userManager.FindByNameAsync(loginDto.Username);
        if (user == null) return null;
        var result = await _userManager.CheckPasswordAsync(user, loginDto.Password);
        if (result == true && await _userManager.IsEmailConfirmedAsync(user))
            return user;
        return null;
    }

    public async Task<bool> Register(RegisterAppUserDto registerDto)
    {
        AppUser user = new()
        {
            UserName = registerDto.Username,
            Email = registerDto.Email,
            PhoneNumber = registerDto.PhoneNumber,
            PasswordHash = registerDto.Password,
            Fullname = registerDto.Name + " " + registerDto.Surname,
            EmailConfirmed = true
        };
        await _userManager.CreateAsync(user, registerDto.Password);
        return true;
    }
}
