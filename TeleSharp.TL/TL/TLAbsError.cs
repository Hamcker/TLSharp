using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsErrorTypes
	{
		TLError
	}

    public abstract class TLAbsError : TLObject
    {
		public TLAbsErrorTypes Type { get; set; } 

		public T To<T>() where T : TLAbsError
        {
            return this as T;
        }

		public TLError ToTLError()
		{
			return this as TLError;
		}

    }
}
