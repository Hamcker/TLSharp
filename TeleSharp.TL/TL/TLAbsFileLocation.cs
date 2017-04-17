using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsFileLocationTypes
	{
		TLFileLocationUnavailable,TLFileLocation
	}

    public abstract class TLAbsFileLocation : TLObject
    {
		public TLAbsFileLocationTypes Type { get; set; } 

		public T To<T>() where T : TLAbsFileLocation
        {
            return this as T;
        }

		public TLFileLocationUnavailable ToTLFileLocationUnavailable()
		{
			return this as TLFileLocationUnavailable;
		}

		public TLFileLocation ToTLFileLocation()
		{
			return this as TLFileLocation;
		}

    }
}
