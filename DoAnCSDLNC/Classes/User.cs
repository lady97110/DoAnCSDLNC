using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSDLNC.Classes
{
    class User
    {
        private int userId;
        private string userName;
        private string password;
        private int userType;

        public User()
        {
            this.userType = -1;
        }

        public User(int userId, string userName, string password, int userType)
        {
            this.userId = userId;
            this.userName = userName;
            this.password = password;
            this.userType = userType;
        }

        public int UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int UserType
        {
            get
            {
                return userType;
            }

            set
            {
                userType = value;
            }
        }
    }
}
