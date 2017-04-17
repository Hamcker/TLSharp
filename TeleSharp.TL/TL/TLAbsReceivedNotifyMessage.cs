using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsReceivedNotifyMessageTypes
	{
		TLReceivedNotifyMessage
	}

    public abstract class TLAbsReceivedNotifyMessage : TLObject
    {
		public TLAbsReceivedNotifyMessageTypes Type { get; set; } 

		public T To<T>() where T : TLAbsReceivedNotifyMessage
        {
            return this as T;
        }

		public TLReceivedNotifyMessage ToTLReceivedNotifyMessage()
		{
			return this as TLReceivedNotifyMessage;
		}

    }
}
