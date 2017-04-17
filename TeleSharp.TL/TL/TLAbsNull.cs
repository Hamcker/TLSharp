using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsNullTypes
	{
		TLNull
	}

    public abstract class TLAbsNull : TLObject
    {
		public TLAbsNullTypes Type { get; set; } 

		public T To<T>() where T : TLAbsNull
        {
            return this as T;
        }

		public TLNull ToTLNull()
		{
			return this as TLNull;
		}

    }
}
