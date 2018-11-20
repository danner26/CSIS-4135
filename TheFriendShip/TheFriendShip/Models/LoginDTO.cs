using System.Security.Claims;

namespace TheFriendShip.Models
{
    internal class LoginDTO
    {
        public ClaimsIdentity UserName { get; internal set; }
    }
}