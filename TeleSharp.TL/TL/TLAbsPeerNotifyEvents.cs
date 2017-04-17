using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsPeerNotifyEventsTypes
	{
		TLPeerNotifyEventsEmpty,TLPeerNotifyEventsAll
	}

    public abstract class TLAbsPeerNotifyEvents : TLObject
    {
		public TLAbsPeerNotifyEventsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPeerNotifyEvents
        {
            return this as T;
        }

		public TLPeerNotifyEventsEmpty ToTLPeerNotifyEventsEmpty()
		{
			return this as TLPeerNotifyEventsEmpty;
		}

		public TLPeerNotifyEventsAll ToTLPeerNotifyEventsAll()
		{
			return this as TLPeerNotifyEventsAll;
		}

    }
}
