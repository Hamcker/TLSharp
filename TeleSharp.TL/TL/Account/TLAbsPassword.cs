using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Account
{
	public enum TLAbsPasswordTypes
	{
		TLNoPassword,TLPassword
	}

    public abstract class TLAbsPassword : TLObject
    {
		public TLAbsPasswordTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPassword
        {
            return this as T;
        }

		public TLNoPassword ToTLNoPassword()
		{
			return this as TLNoPassword;
		}

		public TLPassword ToTLPassword()
		{
			return this as TLPassword;
		}

    }
}
