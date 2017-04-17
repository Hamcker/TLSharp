using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Auth
{
	public enum TLAbsSentCodeTypeTypes
	{
		TLSentCodeTypeApp,TLSentCodeTypeSms,TLSentCodeTypeCall,TLSentCodeTypeFlashCall
	}

    public abstract class TLAbsSentCodeType : TLObject
    {
		public TLAbsSentCodeTypeTypes Type { get; set; } 

		public T To<T>() where T : TLAbsSentCodeType
        {
            return this as T;
        }

		public TLSentCodeTypeApp ToTLSentCodeTypeApp()
		{
			return this as TLSentCodeTypeApp;
		}

		public TLSentCodeTypeSms ToTLSentCodeTypeSms()
		{
			return this as TLSentCodeTypeSms;
		}

		public TLSentCodeTypeCall ToTLSentCodeTypeCall()
		{
			return this as TLSentCodeTypeCall;
		}

		public TLSentCodeTypeFlashCall ToTLSentCodeTypeFlashCall()
		{
			return this as TLSentCodeTypeFlashCall;
		}

    }
}
