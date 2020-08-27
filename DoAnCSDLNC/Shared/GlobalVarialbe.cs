using DoAnCSDLNC.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSDLNC.Shared
{
    class GlobalVarialbe
    {
        public static Tour selectedTour = new Tour();
        public static Customer selectedCustomer = new Customer();
        public static Contract selectedContract = new Contract();
        public static User selectedUser = new User();
        public static bool isLogin = false;
    }
}
