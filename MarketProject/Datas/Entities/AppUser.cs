using Microsoft.AspNetCore.Identity;

namespace MarketProject.Datas.Entities;
public class AppUser:IdentityUser
{
    public string Fullname { get; set; }
}
