using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsDocumentAttributeTypes
	{
		TLDocumentAttributeImageSize,TLDocumentAttributeAnimated,TLDocumentAttributeSticker,TLDocumentAttributeVideo,TLDocumentAttributeAudio,TLDocumentAttributeFilename,TLDocumentAttributeHasStickers
	}

    public abstract class TLAbsDocumentAttribute : TLObject
    {
		public TLAbsDocumentAttributeTypes Type { get; set; } 

		public T To<T>() where T : TLAbsDocumentAttribute
        {
            return this as T;
        }

		public TLDocumentAttributeImageSize ToTLDocumentAttributeImageSize()
		{
			return this as TLDocumentAttributeImageSize;
		}

		public TLDocumentAttributeAnimated ToTLDocumentAttributeAnimated()
		{
			return this as TLDocumentAttributeAnimated;
		}

		public TLDocumentAttributeSticker ToTLDocumentAttributeSticker()
		{
			return this as TLDocumentAttributeSticker;
		}

		public TLDocumentAttributeVideo ToTLDocumentAttributeVideo()
		{
			return this as TLDocumentAttributeVideo;
		}

		public TLDocumentAttributeAudio ToTLDocumentAttributeAudio()
		{
			return this as TLDocumentAttributeAudio;
		}

		public TLDocumentAttributeFilename ToTLDocumentAttributeFilename()
		{
			return this as TLDocumentAttributeFilename;
		}

		public TLDocumentAttributeHasStickers ToTLDocumentAttributeHasStickers()
		{
			return this as TLDocumentAttributeHasStickers;
		}

    }
}
