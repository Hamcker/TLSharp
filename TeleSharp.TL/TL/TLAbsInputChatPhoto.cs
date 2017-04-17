using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputChatPhotoTypes
	{
		TLInputChatPhotoEmpty,TLInputChatUploadedPhoto,TLInputChatPhoto
	}

    public abstract class TLAbsInputChatPhoto : TLObject
    {
		public TLAbsInputChatPhotoTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputChatPhoto
        {
            return this as T;
        }

		public TLInputChatPhotoEmpty ToTLInputChatPhotoEmpty()
		{
			return this as TLInputChatPhotoEmpty;
		}

		public TLInputChatUploadedPhoto ToTLInputChatUploadedPhoto()
		{
			return this as TLInputChatUploadedPhoto;
		}

		public TLInputChatPhoto ToTLInputChatPhoto()
		{
			return this as TLInputChatPhoto;
		}

    }
}
