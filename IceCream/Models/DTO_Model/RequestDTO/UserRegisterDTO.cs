using System.ComponentModel.DataAnnotations;

namespace IceCream.Models.DTO_Model.RequestDTO;

public class UserRegisterDTO
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Contact { get; set; } = string.Empty;
    [Required]
    public string Email { get; set; } = string.Empty;
    [Required]
    public string Address { get; set; } = string.Empty;
    [Required]
    public string Password { get; set; } = string.Empty;

    [Compare("Password", ErrorMessage = "Confirm password does not match")]
    public string ConfirmPassword { get; set; } = string.Empty;

    public int UserType { get; set; } = 0;
    public string? CardNo { get; set; }
    public DateTime JoinDate { get; set; } = DateTime.Now;
    public int IsActive { get; set; } = 1;
    public int IsDelete { get; set; } = 0;
}