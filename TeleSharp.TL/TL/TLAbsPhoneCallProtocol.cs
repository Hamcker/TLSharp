using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsPhoneCallProtocolTypes
	{
		TLPhoneCallProtocol
	}

    public abstract class TLAbsPhoneCallProtocol : TLObject
    {
		public TLAbsPhoneCallProtocolTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPhoneCallProtocol
        {
            return this as T;
        }

		public TLPhoneCallProtocol ToTLPhoneCallProtocol()
		{
			return this as TLPhoneCallProtocol;
		}

    }
}
