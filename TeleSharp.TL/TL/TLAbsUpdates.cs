using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsUpdatesTypes
	{
		TLUpdatesTooLong,TLUpdateShortMessage,TLUpdateShortChatMessage,TLUpdateShort,TLUpdatesCombined,TLUpdates,TLUpdateShortSentMessage
	}

    public abstract class TLAbsUpdates : TLObject
    {
		public TLAbsUpdatesTypes Type { get; set; } 

		public T To<T>() where T : TLAbsUpdates
        {
            return this as T;
        }

		public TLUpdatesTooLong ToTLUpdatesTooLong()
		{
			return this as TLUpdatesTooLong;
		}

		public TLUpdateShortMessage ToTLUpdateShortMessage()
		{
			return this as TLUpdateShortMessage;
		}

		public TLUpdateShortChatMessage ToTLUpdateShortChatMessage()
		{
			return this as TLUpdateShortChatMessage;
		}

		public TLUpdateShort ToTLUpdateShort()
		{
			return this as TLUpdateShort;
		}

		public TLUpdatesCombined ToTLUpdatesCombined()
		{
			return this as TLUpdatesCombined;
		}

		public TLUpdates ToTLUpdates()
		{
			return this as TLUpdates;
		}

		public TLUpdateShortSentMessage ToTLUpdateShortSentMessage()
		{
			return this as TLUpdateShortSentMessage;
		}

    }
}
