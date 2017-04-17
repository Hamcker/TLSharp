using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsPhotoSizeTypes
	{
		TLPhotoSizeEmpty,TLPhotoSize,TLPhotoCachedSize
	}

    public abstract class TLAbsPhotoSize : TLObject
    {
		public TLAbsPhotoSizeTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPhotoSize
        {
            return this as T;
        }

		public TLPhotoSizeEmpty ToTLPhotoSizeEmpty()
		{
			return this as TLPhotoSizeEmpty;
		}

		public TLPhotoSize ToTLPhotoSize()
		{
			return this as TLPhotoSize;
		}

		public TLPhotoCachedSize ToTLPhotoCachedSize()
		{
			return this as TLPhotoCachedSize;
		}

    }
}
