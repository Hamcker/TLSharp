using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsSavedGifsTypes
	{
		TLSavedGifsNotModified,TLSavedGifs
	}

    public abstract class TLAbsSavedGifs : TLObject
    {
		public TLAbsSavedGifsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsSavedGifs
        {
            return this as T;
        }

		public TLSavedGifsNotModified ToTLSavedGifsNotModified()
		{
			return this as TLSavedGifsNotModified;
		}

		public TLSavedGifs ToTLSavedGifs()
		{
			return this as TLSavedGifs;
		}

    }
}
