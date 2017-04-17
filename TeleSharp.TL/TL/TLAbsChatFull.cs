using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsChatFullTypes
	{
		TLChatFull,TLChannelFull
	}

    public abstract class TLAbsChatFull : TLObject
    {
		public TLAbsChatFullTypes Type { get; set; } 

		public T To<T>() where T : TLAbsChatFull
        {
            return this as T;
        }

		public TLChatFull ToTLChatFull()
		{
			return this as TLChatFull;
		}

		public TLChannelFull ToTLChannelFull()
		{
			return this as TLChannelFull;
		}

    }
}
