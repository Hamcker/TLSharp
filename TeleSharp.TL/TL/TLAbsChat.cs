using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsChatTypes
	{
		TLChatEmpty,TLChat,TLChatForbidden,TLChannel,TLChannelForbidden
	}

    public abstract class TLAbsChat : TLObject
    {
		public TLAbsChatTypes Type { get; set; } 

		public T To<T>() where T : TLAbsChat
        {
            return this as T;
        }

		public TLChatEmpty ToTLChatEmpty()
		{
			return this as TLChatEmpty;
		}

		public TLChat ToTLChat()
		{
			return this as TLChat;
		}

		public TLChatForbidden ToTLChatForbidden()
		{
			return this as TLChatForbidden;
		}

		public TLChannel ToTLChannel()
		{
			return this as TLChannel;
		}

		public TLChannelForbidden ToTLChannelForbidden()
		{
			return this as TLChannelForbidden;
		}

    }
}
