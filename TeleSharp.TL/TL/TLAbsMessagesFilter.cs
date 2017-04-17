using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsMessagesFilterTypes
	{
		TLInputMessagesFilterEmpty,TLInputMessagesFilterPhotos,TLInputMessagesFilterVideo,TLInputMessagesFilterPhotoVideo,TLInputMessagesFilterPhotoVideoDocuments,TLInputMessagesFilterDocument,TLInputMessagesFilterUrl,TLInputMessagesFilterGif,TLInputMessagesFilterVoice,TLInputMessagesFilterMusic,TLInputMessagesFilterChatPhotos,TLInputMessagesFilterPhoneCalls
	}

    public abstract class TLAbsMessagesFilter : TLObject
    {
		public TLAbsMessagesFilterTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMessagesFilter
        {
            return this as T;
        }

		public TLInputMessagesFilterEmpty ToTLInputMessagesFilterEmpty()
		{
			return this as TLInputMessagesFilterEmpty;
		}

		public TLInputMessagesFilterPhotos ToTLInputMessagesFilterPhotos()
		{
			return this as TLInputMessagesFilterPhotos;
		}

		public TLInputMessagesFilterVideo ToTLInputMessagesFilterVideo()
		{
			return this as TLInputMessagesFilterVideo;
		}

		public TLInputMessagesFilterPhotoVideo ToTLInputMessagesFilterPhotoVideo()
		{
			return this as TLInputMessagesFilterPhotoVideo;
		}

		public TLInputMessagesFilterPhotoVideoDocuments ToTLInputMessagesFilterPhotoVideoDocuments()
		{
			return this as TLInputMessagesFilterPhotoVideoDocuments;
		}

		public TLInputMessagesFilterDocument ToTLInputMessagesFilterDocument()
		{
			return this as TLInputMessagesFilterDocument;
		}

		public TLInputMessagesFilterUrl ToTLInputMessagesFilterUrl()
		{
			return this as TLInputMessagesFilterUrl;
		}

		public TLInputMessagesFilterGif ToTLInputMessagesFilterGif()
		{
			return this as TLInputMessagesFilterGif;
		}

		public TLInputMessagesFilterVoice ToTLInputMessagesFilterVoice()
		{
			return this as TLInputMessagesFilterVoice;
		}

		public TLInputMessagesFilterMusic ToTLInputMessagesFilterMusic()
		{
			return this as TLInputMessagesFilterMusic;
		}

		public TLInputMessagesFilterChatPhotos ToTLInputMessagesFilterChatPhotos()
		{
			return this as TLInputMessagesFilterChatPhotos;
		}

		public TLInputMessagesFilterPhoneCalls ToTLInputMessagesFilterPhoneCalls()
		{
			return this as TLInputMessagesFilterPhoneCalls;
		}

    }
}
