using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService //Contract between an interface and our implementation
    {
         string CreateToken(AppUser user);
    }
}