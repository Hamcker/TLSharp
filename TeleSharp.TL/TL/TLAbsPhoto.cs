using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsPhotoTypes
	{
		TLPhotoEmpty,TLPhoto
	}

    public abstract class TLAbsPhoto : TLObject
    {
		public TLAbsPhotoTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPhoto
        {
            return this as T;
        }

		public TLPhotoEmpty ToTLPhotoEmpty()
		{
			return this as TLPhotoEmpty;
		}

		public TLPhoto ToTLPhoto()
		{
			return this as TLPhoto;
		}

    }
}
