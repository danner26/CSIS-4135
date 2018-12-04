using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TheFriendShip.Models
{
    public class User : IdentityUser
    {
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public User()
        {
            Photos = new Collection<Photo>();
        }
    }

    public class Photo
    {
        public int ID { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsProfilePic { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
    }
}