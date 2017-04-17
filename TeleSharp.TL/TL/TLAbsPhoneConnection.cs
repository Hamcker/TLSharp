using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsPhoneConnectionTypes
	{
		TLPhoneConnection
	}

    public abstract class TLAbsPhoneConnection : TLObject
    {
		public TLAbsPhoneConnectionTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPhoneConnection
        {
            return this as T;
        }

		public TLPhoneConnection ToTLPhoneConnection()
		{
			return this as TLPhoneConnection;
		}

    }
}
