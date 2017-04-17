using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsRecentStickersTypes
	{
		TLRecentStickersNotModified,TLRecentStickers
	}

    public abstract class TLAbsRecentStickers : TLObject
    {
		public TLAbsRecentStickersTypes Type { get; set; } 

		public T To<T>() where T : TLAbsRecentStickers
        {
            return this as T;
        }

		public TLRecentStickersNotModified ToTLRecentStickersNotModified()
		{
			return this as TLRecentStickersNotModified;
		}

		public TLRecentStickers ToTLRecentStickers()
		{
			return this as TLRecentStickers;
		}

    }
}
