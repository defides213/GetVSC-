using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    public class User
    {
        public string UserName;
        public string Password;
        public List<Friend> Friends;
        public User(string name, string password) 
        {
            UserName = name;
            Password = password;
            Friends = new List<Friend>();
        }
    }
}
