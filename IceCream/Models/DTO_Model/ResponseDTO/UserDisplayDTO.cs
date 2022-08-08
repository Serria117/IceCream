using System.ComponentModel.DataAnnotations;

namespace IceCream.Models.DTO_Model.ResponseDTO;

public class UserDisplayDTO
{
    public int UserId { get; set; }
    public string? Name { get; set; }
    public string? Contact { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public int UserType { get; set; }
    public string? CardNo { get; set; }
    [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
    public DateTime JoinDate { get; set; }
    public int IsActive { get; set; }
}