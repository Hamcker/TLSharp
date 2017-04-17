using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsMessageMediaTypes
	{
		TLMessageMediaEmpty,TLMessageMediaPhoto,TLMessageMediaGeo,TLMessageMediaContact,TLMessageMediaUnsupported,TLMessageMediaDocument,TLMessageMediaWebPage,TLMessageMediaVenue,TLMessageMediaGame
	}

    public abstract class TLAbsMessageMedia : TLObject
    {
		public TLAbsMessageMediaTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMessageMedia
        {
            return this as T;
        }

		public TLMessageMediaEmpty ToTLMessageMediaEmpty()
		{
			return this as TLMessageMediaEmpty;
		}

		public TLMessageMediaPhoto ToTLMessageMediaPhoto()
		{
			return this as TLMessageMediaPhoto;
		}

		public TLMessageMediaGeo ToTLMessageMediaGeo()
		{
			return this as TLMessageMediaGeo;
		}

		public TLMessageMediaContact ToTLMessageMediaContact()
		{
			return this as TLMessageMediaContact;
		}

		public TLMessageMediaUnsupported ToTLMessageMediaUnsupported()
		{
			return this as TLMessageMediaUnsupported;
		}

		public TLMessageMediaDocument ToTLMessageMediaDocument()
		{
			return this as TLMessageMediaDocument;
		}

		public TLMessageMediaWebPage ToTLMessageMediaWebPage()
		{
			return this as TLMessageMediaWebPage;
		}

		public TLMessageMediaVenue ToTLMessageMediaVenue()
		{
			return this as TLMessageMediaVenue;
		}

		public TLMessageMediaGame ToTLMessageMediaGame()
		{
			return this as TLMessageMediaGame;
		}

    }
}
