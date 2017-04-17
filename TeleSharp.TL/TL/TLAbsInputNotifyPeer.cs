using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputNotifyPeerTypes
	{
		TLInputNotifyPeer,TLInputNotifyUsers,TLInputNotifyChats,TLInputNotifyAll
	}

    public abstract class TLAbsInputNotifyPeer : TLObject
    {
		public TLAbsInputNotifyPeerTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputNotifyPeer
        {
            return this as T;
        }

		public TLInputNotifyPeer ToTLInputNotifyPeer()
		{
			return this as TLInputNotifyPeer;
		}

		public TLInputNotifyUsers ToTLInputNotifyUsers()
		{
			return this as TLInputNotifyUsers;
		}

		public TLInputNotifyChats ToTLInputNotifyChats()
		{
			return this as TLInputNotifyChats;
		}

		public TLInputNotifyAll ToTLInputNotifyAll()
		{
			return this as TLInputNotifyAll;
		}

    }
}
