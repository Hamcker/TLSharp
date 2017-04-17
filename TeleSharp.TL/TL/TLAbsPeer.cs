using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsPeerTypes
	{
		TLPeerUser,TLPeerChat,TLPeerChannel
	}

    public abstract class TLAbsPeer : TLObject
    {
		public TLAbsPeerTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPeer
        {
            return this as T;
        }

		public TLPeerUser ToTLPeerUser()
		{
			return this as TLPeerUser;
		}

		public TLPeerChat ToTLPeerChat()
		{
			return this as TLPeerChat;
		}

		public TLPeerChannel ToTLPeerChannel()
		{
			return this as TLPeerChannel;
		}

    }
}
