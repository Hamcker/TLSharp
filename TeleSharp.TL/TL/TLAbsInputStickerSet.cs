using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputStickerSetTypes
	{
		TLInputStickerSetEmpty,TLInputStickerSetID,TLInputStickerSetShortName
	}

    public abstract class TLAbsInputStickerSet : TLObject
    {
		public TLAbsInputStickerSetTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputStickerSet
        {
            return this as T;
        }

		public TLInputStickerSetEmpty ToTLInputStickerSetEmpty()
		{
			return this as TLInputStickerSetEmpty;
		}

		public TLInputStickerSetID ToTLInputStickerSetID()
		{
			return this as TLInputStickerSetID;
		}

		public TLInputStickerSetShortName ToTLInputStickerSetShortName()
		{
			return this as TLInputStickerSetShortName;
		}

    }
}
