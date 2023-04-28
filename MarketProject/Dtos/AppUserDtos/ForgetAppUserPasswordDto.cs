using System.ComponentModel.DataAnnotations;

namespace MarketProject.Dtos.AppUserDtos;
public class ForgetAppUserPasswordDto
{
    public string Email { get; set; }
    public string Password { get; set; }
    [Compare("Password")]
    public string ConfirmPassword { get; set; }
}
