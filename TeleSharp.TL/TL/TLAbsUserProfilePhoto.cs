using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsUserProfilePhotoTypes
	{
		TLUserProfilePhotoEmpty,TLUserProfilePhoto
	}

    public abstract class TLAbsUserProfilePhoto : TLObject
    {
		public TLAbsUserProfilePhotoTypes Type { get; set; } 

		public T To<T>() where T : TLAbsUserProfilePhoto
        {
            return this as T;
        }

		public TLUserProfilePhotoEmpty ToTLUserProfilePhotoEmpty()
		{
			return this as TLUserProfilePhotoEmpty;
		}

		public TLUserProfilePhoto ToTLUserProfilePhoto()
		{
			return this as TLUserProfilePhoto;
		}

    }
}
