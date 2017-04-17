using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Phone
{
	public enum TLAbsPhoneCallTypes
	{
		TLPhoneCall
	}

    public abstract class TLAbsPhoneCall : TLObject
    {
		public TLAbsPhoneCallTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPhoneCall
        {
            return this as T;
        }

		public TLPhoneCall ToTLPhoneCall()
		{
			return this as TLPhoneCall;
		}

    }
}
