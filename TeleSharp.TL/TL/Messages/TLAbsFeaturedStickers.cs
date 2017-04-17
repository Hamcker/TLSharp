using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsFeaturedStickersTypes
	{
		TLFeaturedStickersNotModified,TLFeaturedStickers
	}

    public abstract class TLAbsFeaturedStickers : TLObject
    {
		public TLAbsFeaturedStickersTypes Type { get; set; } 

		public T To<T>() where T : TLAbsFeaturedStickers
        {
            return this as T;
        }

		public TLFeaturedStickersNotModified ToTLFeaturedStickersNotModified()
		{
			return this as TLFeaturedStickersNotModified;
		}

		public TLFeaturedStickers ToTLFeaturedStickers()
		{
			return this as TLFeaturedStickers;
		}

    }
}
