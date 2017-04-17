using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsChatInviteTypes
	{
		TLChatInviteAlready,TLChatInvite
	}

    public abstract class TLAbsChatInvite : TLObject
    {
		public TLAbsChatInviteTypes Type { get; set; } 

		public T To<T>() where T : TLAbsChatInvite
        {
            return this as T;
        }

		public TLChatInviteAlready ToTLChatInviteAlready()
		{
			return this as TLChatInviteAlready;
		}

		public TLChatInvite ToTLChatInvite()
		{
			return this as TLChatInvite;
		}

    }
}
