using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.Models
{
   public class UserDataModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public UserDataModel Clone()
        {
            return new UserDataModel { Name = this.Name, Password =this. Password, Email = this.Email };
        }
    }
}
