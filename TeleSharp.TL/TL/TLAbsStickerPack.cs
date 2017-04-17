using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsStickerPackTypes
	{
		TLStickerPack
	}

    public abstract class TLAbsStickerPack : TLObject
    {
		public TLAbsStickerPackTypes Type { get; set; } 

		public T To<T>() where T : TLAbsStickerPack
        {
            return this as T;
        }

		public TLStickerPack ToTLStickerPack()
		{
			return this as TLStickerPack;
		}

    }
}
