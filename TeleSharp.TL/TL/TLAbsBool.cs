using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsBoolTypes
	{
		TLBoolFalse,TLBoolTrue
	}

    public abstract class TLAbsBool : TLObject
    {
		public TLAbsBoolTypes Type { get; set; } 

		public T To<T>() where T : TLAbsBool
        {
            return this as T;
        }

		public TLBoolFalse ToTLBoolFalse()
		{
			return this as TLBoolFalse;
		}

		public TLBoolTrue ToTLBoolTrue()
		{
			return this as TLBoolTrue;
		}

    }
}
