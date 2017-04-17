using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsUserTypes
	{
		TLUserEmpty,TLUser
	}

    public abstract class TLAbsUser : TLObject
    {
		public TLAbsUserTypes Type { get; set; } 

		public T To<T>() where T : TLAbsUser
        {
            return this as T;
        }

		public TLUserEmpty ToTLUserEmpty()
		{
			return this as TLUserEmpty;
		}

		public TLUser ToTLUser()
		{
			return this as TLUser;
		}

    }
}
