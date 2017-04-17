using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputPeerNotifyEventsTypes
	{
		TLInputPeerNotifyEventsEmpty,TLInputPeerNotifyEventsAll
	}

    public abstract class TLAbsInputPeerNotifyEvents : TLObject
    {
		public TLAbsInputPeerNotifyEventsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputPeerNotifyEvents
        {
            return this as T;
        }

		public TLInputPeerNotifyEventsEmpty ToTLInputPeerNotifyEventsEmpty()
		{
			return this as TLInputPeerNotifyEventsEmpty;
		}

		public TLInputPeerNotifyEventsAll ToTLInputPeerNotifyEventsAll()
		{
			return this as TLInputPeerNotifyEventsAll;
		}

    }
}
