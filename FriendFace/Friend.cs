using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    public class Friend
    {
        public string FirstName;
        public string LastName;
        public int Id; 
        public Friend(string firstName, string lastName, int iD) 
        {
            FirstName = firstName;
            LastName = lastName;
            Id = iD;
        }

    }
}
