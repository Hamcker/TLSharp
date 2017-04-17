using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Auth
{
	public enum TLAbsSentCodeTypes
	{
		TLSentCode
	}

    public abstract class TLAbsSentCode : TLObject
    {
		public TLAbsSentCodeTypes Type { get; set; } 

		public T To<T>() where T : TLAbsSentCode
        {
            return this as T;
        }

		public TLSentCode ToTLSentCode()
		{
			return this as TLSentCode;
		}

    }
}
