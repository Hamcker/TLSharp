using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsChatPhotoTypes
	{
		TLChatPhotoEmpty,TLChatPhoto
	}

    public abstract class TLAbsChatPhoto : TLObject
    {
		public TLAbsChatPhotoTypes Type { get; set; } 

		public T To<T>() where T : TLAbsChatPhoto
        {
            return this as T;
        }

		public TLChatPhotoEmpty ToTLChatPhotoEmpty()
		{
			return this as TLChatPhotoEmpty;
		}

		public TLChatPhoto ToTLChatPhoto()
		{
			return this as TLChatPhoto;
		}

    }
}
