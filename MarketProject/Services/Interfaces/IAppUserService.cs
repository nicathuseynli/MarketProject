using MarketProject.Datas.Entities;
using MarketProject.Dtos.AppUserDtos;

namespace MarketProject.Services.Interfaces;
public interface IAppUserService
{
    public Task<AppUser> Login(LoginAppUserDto loginDto);
    public Task<bool> Register(RegisterAppUserDto registerDto);
    public Task<bool> ForgetPasswordAsync(ForgetAppUserPasswordDto forgetPasswordDto);
    public Task<bool> ChangePasswordAsync(ChangeAppUserPasswordDto changePasswordDto);
}
