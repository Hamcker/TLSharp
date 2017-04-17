using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Auth
{
	public enum TLAbsCodeTypeTypes
	{
		TLCodeTypeSms,TLCodeTypeCall,TLCodeTypeFlashCall
	}

    public abstract class TLAbsCodeType : TLObject
    {
		public TLAbsCodeTypeTypes Type { get; set; } 

		public T To<T>() where T : TLAbsCodeType
        {
            return this as T;
        }

		public TLCodeTypeSms ToTLCodeTypeSms()
		{
			return this as TLCodeTypeSms;
		}

		public TLCodeTypeCall ToTLCodeTypeCall()
		{
			return this as TLCodeTypeCall;
		}

		public TLCodeTypeFlashCall ToTLCodeTypeFlashCall()
		{
			return this as TLCodeTypeFlashCall;
		}

    }
}
