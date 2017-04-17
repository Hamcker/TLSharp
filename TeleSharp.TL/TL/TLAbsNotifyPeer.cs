using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsNotifyPeerTypes
	{
		TLNotifyPeer,TLNotifyUsers,TLNotifyChats,TLNotifyAll
	}

    public abstract class TLAbsNotifyPeer : TLObject
    {
		public TLAbsNotifyPeerTypes Type { get; set; } 

		public T To<T>() where T : TLAbsNotifyPeer
        {
            return this as T;
        }

		public TLNotifyPeer ToTLNotifyPeer()
		{
			return this as TLNotifyPeer;
		}

		public TLNotifyUsers ToTLNotifyUsers()
		{
			return this as TLNotifyUsers;
		}

		public TLNotifyChats ToTLNotifyChats()
		{
			return this as TLNotifyChats;
		}

		public TLNotifyAll ToTLNotifyAll()
		{
			return this as TLNotifyAll;
		}

    }
}
