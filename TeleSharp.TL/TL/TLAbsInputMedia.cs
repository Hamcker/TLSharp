using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputMediaTypes
	{
		TLInputMediaEmpty,TLInputMediaUploadedPhoto,TLInputMediaPhoto,TLInputMediaGeoPoint,TLInputMediaContact,TLInputMediaUploadedDocument,TLInputMediaUploadedThumbDocument,TLInputMediaDocument,TLInputMediaVenue,TLInputMediaGifExternal,TLInputMediaPhotoExternal,TLInputMediaDocumentExternal,TLInputMediaGame
	}

    public abstract class TLAbsInputMedia : TLObject
    {
		public TLAbsInputMediaTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputMedia
        {
            return this as T;
        }

		public TLInputMediaEmpty ToTLInputMediaEmpty()
		{
			return this as TLInputMediaEmpty;
		}

		public TLInputMediaUploadedPhoto ToTLInputMediaUploadedPhoto()
		{
			return this as TLInputMediaUploadedPhoto;
		}

		public TLInputMediaPhoto ToTLInputMediaPhoto()
		{
			return this as TLInputMediaPhoto;
		}

		public TLInputMediaGeoPoint ToTLInputMediaGeoPoint()
		{
			return this as TLInputMediaGeoPoint;
		}

		public TLInputMediaContact ToTLInputMediaContact()
		{
			return this as TLInputMediaContact;
		}

		public TLInputMediaUploadedDocument ToTLInputMediaUploadedDocument()
		{
			return this as TLInputMediaUploadedDocument;
		}

		public TLInputMediaUploadedThumbDocument ToTLInputMediaUploadedThumbDocument()
		{
			return this as TLInputMediaUploadedThumbDocument;
		}

		public TLInputMediaDocument ToTLInputMediaDocument()
		{
			return this as TLInputMediaDocument;
		}

		public TLInputMediaVenue ToTLInputMediaVenue()
		{
			return this as TLInputMediaVenue;
		}

		public TLInputMediaGifExternal ToTLInputMediaGifExternal()
		{
			return this as TLInputMediaGifExternal;
		}

		public TLInputMediaPhotoExternal ToTLInputMediaPhotoExternal()
		{
			return this as TLInputMediaPhotoExternal;
		}

		public TLInputMediaDocumentExternal ToTLInputMediaDocumentExternal()
		{
			return this as TLInputMediaDocumentExternal;
		}

		public TLInputMediaGame ToTLInputMediaGame()
		{
			return this as TLInputMediaGame;
		}

    }
}
