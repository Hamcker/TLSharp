using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsStickerSetCoveredTypes
	{
		TLStickerSetCovered,TLStickerSetMultiCovered
	}

    public abstract class TLAbsStickerSetCovered : TLObject
    {
		public TLAbsStickerSetCoveredTypes Type { get; set; } 

		public T To<T>() where T : TLAbsStickerSetCovered
        {
            return this as T;
        }

		public TLStickerSetCovered ToTLStickerSetCovered()
		{
			return this as TLStickerSetCovered;
		}

		public TLStickerSetMultiCovered ToTLStickerSetMultiCovered()
		{
			return this as TLStickerSetMultiCovered;
		}

    }
}
