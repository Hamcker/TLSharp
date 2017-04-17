using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsStickerSetTypes
	{
		TLStickerSet
	}

    public abstract class TLAbsStickerSet : TLObject
    {
		public TLAbsStickerSetTypes Type { get; set; } 

		public T To<T>() where T : TLAbsStickerSet
        {
            return this as T;
        }

		public TLStickerSet ToTLStickerSet()
		{
			return this as TLStickerSet;
		}

    }
}
