using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsGeoPointTypes
	{
		TLGeoPointEmpty,TLGeoPoint
	}

    public abstract class TLAbsGeoPoint : TLObject
    {
		public TLAbsGeoPointTypes Type { get; set; } 

		public T To<T>() where T : TLAbsGeoPoint
        {
            return this as T;
        }

		public TLGeoPointEmpty ToTLGeoPointEmpty()
		{
			return this as TLGeoPointEmpty;
		}

		public TLGeoPoint ToTLGeoPoint()
		{
			return this as TLGeoPoint;
		}

    }
}
