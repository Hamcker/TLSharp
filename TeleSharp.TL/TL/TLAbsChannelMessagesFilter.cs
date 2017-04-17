using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsChannelMessagesFilterTypes
	{
		TLChannelMessagesFilterEmpty,TLChannelMessagesFilter
	}

    public abstract class TLAbsChannelMessagesFilter : TLObject
    {
		public TLAbsChannelMessagesFilterTypes Type { get; set; } 

		public T To<T>() where T : TLAbsChannelMessagesFilter
        {
            return this as T;
        }

		public TLChannelMessagesFilterEmpty ToTLChannelMessagesFilterEmpty()
		{
			return this as TLChannelMessagesFilterEmpty;
		}

		public TLChannelMessagesFilter ToTLChannelMessagesFilter()
		{
			return this as TLChannelMessagesFilter;
		}

    }
}
