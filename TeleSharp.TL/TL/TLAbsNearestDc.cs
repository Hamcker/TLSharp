using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsNearestDcTypes
	{
		TLNearestDc
	}

    public abstract class TLAbsNearestDc : TLObject
    {
		public TLAbsNearestDcTypes Type { get; set; } 

		public T To<T>() where T : TLAbsNearestDc
        {
            return this as T;
        }

		public TLNearestDc ToTLNearestDc()
		{
			return this as TLNearestDc;
		}

    }
}
