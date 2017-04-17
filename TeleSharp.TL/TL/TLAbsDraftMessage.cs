using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsDraftMessageTypes
	{
		TLDraftMessageEmpty,TLDraftMessage
	}

    public abstract class TLAbsDraftMessage : TLObject
    {
		public TLAbsDraftMessageTypes Type { get; set; } 

		public T To<T>() where T : TLAbsDraftMessage
        {
            return this as T;
        }

		public TLDraftMessageEmpty ToTLDraftMessageEmpty()
		{
			return this as TLDraftMessageEmpty;
		}

		public TLDraftMessage ToTLDraftMessage()
		{
			return this as TLDraftMessage;
		}

    }
}
