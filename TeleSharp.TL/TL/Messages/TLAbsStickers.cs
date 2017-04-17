using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsStickersTypes
	{
		TLStickersNotModified,TLStickers
	}

    public abstract class TLAbsStickers : TLObject
    {
		public TLAbsStickersTypes Type { get; set; } 

		public T To<T>() where T : TLAbsStickers
        {
            return this as T;
        }

		public TLStickersNotModified ToTLStickersNotModified()
		{
			return this as TLStickersNotModified;
		}

		public TLStickers ToTLStickers()
		{
			return this as TLStickers;
		}

    }
}
