using System.ComponentModel.DataAnnotations;

namespace MarketProject.Dtos.AppUserDtos;
public class ChangeAppUserPasswordDto
{
    public string Email { get; set; }
    public string CurrentPassword { get; set; }
    public string Password { get; set; }
    [Compare("Password")]
    public string ConfirmPassword { get; set; }
}
