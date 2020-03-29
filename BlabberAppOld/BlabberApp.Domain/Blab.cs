using System;

namespace BlabberApp.Domain
{
    public class Blab : IDatum
    {
        private Guid guid;
        
        private System.DateTime timeStamp;
        private string message;
        private string userId;

        public Blab(string message, string userId,System.DateTime time){
            guid = Guid.NewGuid();
            timeStamp = time;
            this.message = message;
            this.userId = userId;
        }

        public System.DateTime TimeStamp{
            get{
                return timeStamp;
            }
            set{
                timeStamp = value;
            }
        }
        
        public string Message{
            get{
                return message;
            }
            set{
                message = value;
            }
        }
        public string UserId{
            get{
                return userId;
            }
            set{
                userId = value;
            }
        }

        public string getsysid()
        {
            return guid.ToString();
        }
    }
}