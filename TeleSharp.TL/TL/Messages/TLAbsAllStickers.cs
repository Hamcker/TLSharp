using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsAllStickersTypes
	{
		TLAllStickersNotModified,TLAllStickers
	}

    public abstract class TLAbsAllStickers : TLObject
    {
		public TLAbsAllStickersTypes Type { get; set; } 

		public T To<T>() where T : TLAbsAllStickers
        {
            return this as T;
        }

		public TLAllStickersNotModified ToTLAllStickersNotModified()
		{
			return this as TLAllStickersNotModified;
		}

		public TLAllStickers ToTLAllStickers()
		{
			return this as TLAllStickers;
		}

    }
}
