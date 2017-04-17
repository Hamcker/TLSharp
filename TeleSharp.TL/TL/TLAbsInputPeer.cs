using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputPeerTypes
	{
		TLInputPeerEmpty,TLInputPeerSelf,TLInputPeerChat,TLInputPeerUser,TLInputPeerChannel
	}

    public abstract class TLAbsInputPeer : TLObject
    {
		public TLAbsInputPeerTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputPeer
        {
            return this as T;
        }

		public TLInputPeerEmpty ToTLInputPeerEmpty()
		{
			return this as TLInputPeerEmpty;
		}

		public TLInputPeerSelf ToTLInputPeerSelf()
		{
			return this as TLInputPeerSelf;
		}

		public TLInputPeerChat ToTLInputPeerChat()
		{
			return this as TLInputPeerChat;
		}

		public TLInputPeerUser ToTLInputPeerUser()
		{
			return this as TLInputPeerUser;
		}

		public TLInputPeerChannel ToTLInputPeerChannel()
		{
			return this as TLInputPeerChannel;
		}

    }
}
