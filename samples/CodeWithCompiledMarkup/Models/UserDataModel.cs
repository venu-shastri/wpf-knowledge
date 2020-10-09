using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithCompiledMarkup.Models
{
   public  class UserDataModel:INotifyPropertyChanged
    {
        string userName, password, email;
        public string UserName { get { return this.userName; } set {
                
                if (value != this.userName)
                {

                    this.userName = value;
                    OnPropertyChanged("UserName");
                }

            }
        }
        public string Password { get { return this.password; } set { this.password = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
