using TheFriendShip.Models;

namespace TheFriendShip.Models
{
    public class LoginVM
    {
        public User UserName { get; internal set; }
        public string Password { get; internal set; }
    }
}