using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputPhotoTypes
	{
		TLInputPhotoEmpty,TLInputPhoto
	}

    public abstract class TLAbsInputPhoto : TLObject
    {
		public TLAbsInputPhotoTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputPhoto
        {
            return this as T;
        }

		public TLInputPhotoEmpty ToTLInputPhotoEmpty()
		{
			return this as TLInputPhotoEmpty;
		}

		public TLInputPhoto ToTLInputPhoto()
		{
			return this as TLInputPhoto;
		}

    }
}
