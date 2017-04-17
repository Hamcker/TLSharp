using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Contacts
{
	public enum TLAbsBlockedTypes
	{
		TLBlocked,TLBlockedSlice
	}

    public abstract class TLAbsBlocked : TLObject
    {
		public TLAbsBlockedTypes Type { get; set; } 

		public T To<T>() where T : TLAbsBlocked
        {
            return this as T;
        }

		public TLBlocked ToTLBlocked()
		{
			return this as TLBlocked;
		}

		public TLBlockedSlice ToTLBlockedSlice()
		{
			return this as TLBlockedSlice;
		}

    }
}
