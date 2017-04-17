using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsMessagesTypes
	{
		TLMessages,TLMessagesSlice,TLChannelMessages
	}

    public abstract class TLAbsMessages : TLObject
    {
		public TLAbsMessagesTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMessages
        {
            return this as T;
        }

		public TLMessages ToTLMessages()
		{
			return this as TLMessages;
		}

		public TLMessagesSlice ToTLMessagesSlice()
		{
			return this as TLMessagesSlice;
		}

		public TLChannelMessages ToTLChannelMessages()
		{
			return this as TLChannelMessages;
		}

    }
}
