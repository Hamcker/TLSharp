using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsFoundGifTypes
	{
		TLFoundGif,TLFoundGifCached
	}

    public abstract class TLAbsFoundGif : TLObject
    {
		public TLAbsFoundGifTypes Type { get; set; } 

		public T To<T>() where T : TLAbsFoundGif
        {
            return this as T;
        }

		public TLFoundGif ToTLFoundGif()
		{
			return this as TLFoundGif;
		}

		public TLFoundGifCached ToTLFoundGifCached()
		{
			return this as TLFoundGifCached;
		}

    }
}
