using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsStickerSetInstallResultTypes
	{
		TLStickerSetInstallResultSuccess,TLStickerSetInstallResultArchive
	}

    public abstract class TLAbsStickerSetInstallResult : TLObject
    {
		public TLAbsStickerSetInstallResultTypes Type { get; set; } 

		public T To<T>() where T : TLAbsStickerSetInstallResult
        {
            return this as T;
        }

		public TLStickerSetInstallResultSuccess ToTLStickerSetInstallResultSuccess()
		{
			return this as TLStickerSetInstallResultSuccess;
		}

		public TLStickerSetInstallResultArchive ToTLStickerSetInstallResultArchive()
		{
			return this as TLStickerSetInstallResultArchive;
		}

    }
}
