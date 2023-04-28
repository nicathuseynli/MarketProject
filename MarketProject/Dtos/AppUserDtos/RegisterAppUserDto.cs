using System.ComponentModel.DataAnnotations;

namespace MarketProject.Dtos.AppUserDtos;
public class RegisterAppUserDto
{
    public string Username { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    [Compare("Password")]
    public string ConfirmPassword { get; set; }
}
