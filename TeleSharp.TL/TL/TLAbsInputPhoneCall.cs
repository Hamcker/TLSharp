using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputPhoneCallTypes
	{
		TLInputPhoneCall
	}

    public abstract class TLAbsInputPhoneCall : TLObject
    {
		public TLAbsInputPhoneCallTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputPhoneCall
        {
            return this as T;
        }

		public TLInputPhoneCall ToTLInputPhoneCall()
		{
			return this as TLInputPhoneCall;
		}

    }
}
