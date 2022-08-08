using IceCream.Models.DTO_Model.RequestDTO;
using IceCream.Models.DTO_Model.ResponseDTO;
using IceCream.Models.Entities;

namespace IceCream.Utils;

public static class ObjectMapper
{
    public static UserDisplayDTO? Convert(this User? u)
    {
        return u == null
            ? null
            : new UserDisplayDTO
            {
                UserId = u.UserId,
                Name = u.Name,
                Address = u.Address,
                Contact = u.Contact,
                Email = u.Email,
                JoinDate = u.JoinDate,
                CardNo = u.CardNo,
                IsActive = u.IsActive,
                UserType = u.UserType
            };
    }

    public static User? Convert(this UserRegisterDTO? u)
    {
        return u == null
            ? null
            : new User
            {
                Name = u.Name,
                Address = u.Address,
                Contact = u.Contact,
                Email = u.Email,
                JoinDate = u.JoinDate,
                CardNo = u.CardNo,
                IsActive = u.IsActive,
                UserType = u.UserType
            };
    }
}