using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsUserFullTypes
	{
		TLUserFull
	}

    public abstract class TLAbsUserFull : TLObject
    {
		public TLAbsUserFullTypes Type { get; set; } 

		public T To<T>() where T : TLAbsUserFull
        {
            return this as T;
        }

		public TLUserFull ToTLUserFull()
		{
			return this as TLUserFull;
		}

    }
}
