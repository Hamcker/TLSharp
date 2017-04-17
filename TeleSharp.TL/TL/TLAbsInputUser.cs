using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputUserTypes
	{
		TLInputUserEmpty,TLInputUserSelf,TLInputUser
	}

    public abstract class TLAbsInputUser : TLObject
    {
		public TLAbsInputUserTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputUser
        {
            return this as T;
        }

		public TLInputUserEmpty ToTLInputUserEmpty()
		{
			return this as TLInputUserEmpty;
		}

		public TLInputUserSelf ToTLInputUserSelf()
		{
			return this as TLInputUserSelf;
		}

		public TLInputUser ToTLInputUser()
		{
			return this as TLInputUser;
		}

    }
}
