using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputGeoPointTypes
	{
		TLInputGeoPointEmpty,TLInputGeoPoint
	}

    public abstract class TLAbsInputGeoPoint : TLObject
    {
		public TLAbsInputGeoPointTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputGeoPoint
        {
            return this as T;
        }

		public TLInputGeoPointEmpty ToTLInputGeoPointEmpty()
		{
			return this as TLInputGeoPointEmpty;
		}

		public TLInputGeoPoint ToTLInputGeoPoint()
		{
			return this as TLInputGeoPoint;
		}

    }
}
