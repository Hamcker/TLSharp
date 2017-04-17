using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Photos
{
	public enum TLAbsPhotoTypes
	{
		TLPhoto
	}

    public abstract class TLAbsPhoto : TLObject
    {
		public TLAbsPhotoTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPhoto
        {
            return this as T;
        }

		public TLPhoto ToTLPhoto()
		{
			return this as TLPhoto;
		}

    }
}
