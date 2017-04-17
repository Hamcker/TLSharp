using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsArchivedStickersTypes
	{
		TLArchivedStickers
	}

    public abstract class TLAbsArchivedStickers : TLObject
    {
		public TLAbsArchivedStickersTypes Type { get; set; } 

		public T To<T>() where T : TLAbsArchivedStickers
        {
            return this as T;
        }

		public TLArchivedStickers ToTLArchivedStickers()
		{
			return this as TLArchivedStickers;
		}

    }
}
