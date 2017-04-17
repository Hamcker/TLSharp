using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Photos
{
	public enum TLAbsPhotosTypes
	{
		TLPhotos,TLPhotosSlice
	}

    public abstract class TLAbsPhotos : TLObject
    {
		public TLAbsPhotosTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPhotos
        {
            return this as T;
        }

		public TLPhotos ToTLPhotos()
		{
			return this as TLPhotos;
		}

		public TLPhotosSlice ToTLPhotosSlice()
		{
			return this as TLPhotosSlice;
		}

    }
}
