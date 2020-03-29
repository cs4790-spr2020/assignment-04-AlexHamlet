using System;

namespace BlabberApp.Domain
{
    public class User : IDatum
    {
        private Guid guid;
        private DateTime joinDate;

        private string userName, password, email;

        
        public User(string userName, string password, string email){
            guid = Guid.NewGuid();
            joinDate = DateTime.Now;
            this.userName = userName;
            this.password = password;
            this.email = email;
        }

        public System.DateTime DateJoined{
            get{
                return joinDate;
            }
        }

        public string UserName{
            get{
                return userName;
            }
            set{
                userName = value;
            }
        }

        public string Email{
            get{
                return email;
            }
            set{
                email = value;
            }
        }

        public string getsysid()
        {
            return guid.ToString();
        }
    }
}