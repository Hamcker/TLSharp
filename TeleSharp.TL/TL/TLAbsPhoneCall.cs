using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsPhoneCallTypes
	{
		TLPhoneCallEmpty,TLPhoneCallWaiting,TLPhoneCallRequested,TLPhoneCall,TLPhoneCallDiscarded
	}

    public abstract class TLAbsPhoneCall : TLObject
    {
		public TLAbsPhoneCallTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPhoneCall
        {
            return this as T;
        }

		public TLPhoneCallEmpty ToTLPhoneCallEmpty()
		{
			return this as TLPhoneCallEmpty;
		}

		public TLPhoneCallWaiting ToTLPhoneCallWaiting()
		{
			return this as TLPhoneCallWaiting;
		}

		public TLPhoneCallRequested ToTLPhoneCallRequested()
		{
			return this as TLPhoneCallRequested;
		}

		public TLPhoneCall ToTLPhoneCall()
		{
			return this as TLPhoneCall;
		}

		public TLPhoneCallDiscarded ToTLPhoneCallDiscarded()
		{
			return this as TLPhoneCallDiscarded;
		}

    }
}
