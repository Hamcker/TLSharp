using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsBadMsgNotificationTypes
	{
		TLBad_msg_notification,TLBad_server_salt
	}

    public abstract class TLAbsBadMsgNotification : TLObject
    {
		public TLAbsBadMsgNotificationTypes Type { get; set; } 

		public T To<T>() where T : TLAbsBadMsgNotification
        {
            return this as T;
        }

		public TLBad_msg_notification ToTLBad_msg_notification()
		{
			return this as TLBad_msg_notification;
		}

		public TLBad_server_salt ToTLBad_server_salt()
		{
			return this as TLBad_server_salt;
		}

    }
}
