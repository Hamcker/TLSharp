using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsPhoneCallDiscardReasonTypes
	{
		TLPhoneCallDiscardReasonMissed,TLPhoneCallDiscardReasonDisconnect,TLPhoneCallDiscardReasonHangup,TLPhoneCallDiscardReasonBusy
	}

    public abstract class TLAbsPhoneCallDiscardReason : TLObject
    {
		public TLAbsPhoneCallDiscardReasonTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPhoneCallDiscardReason
        {
            return this as T;
        }

		public TLPhoneCallDiscardReasonMissed ToTLPhoneCallDiscardReasonMissed()
		{
			return this as TLPhoneCallDiscardReasonMissed;
		}

		public TLPhoneCallDiscardReasonDisconnect ToTLPhoneCallDiscardReasonDisconnect()
		{
			return this as TLPhoneCallDiscardReasonDisconnect;
		}

		public TLPhoneCallDiscardReasonHangup ToTLPhoneCallDiscardReasonHangup()
		{
			return this as TLPhoneCallDiscardReasonHangup;
		}

		public TLPhoneCallDiscardReasonBusy ToTLPhoneCallDiscardReasonBusy()
		{
			return this as TLPhoneCallDiscardReasonBusy;
		}

    }
}
