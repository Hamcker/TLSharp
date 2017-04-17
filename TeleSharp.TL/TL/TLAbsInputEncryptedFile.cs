using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputEncryptedFileTypes
	{
		TLInputEncryptedFileEmpty,TLInputEncryptedFileUploaded,TLInputEncryptedFile,TLInputEncryptedFileBigUploaded
	}

    public abstract class TLAbsInputEncryptedFile : TLObject
    {
		public TLAbsInputEncryptedFileTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputEncryptedFile
        {
            return this as T;
        }

		public TLInputEncryptedFileEmpty ToTLInputEncryptedFileEmpty()
		{
			return this as TLInputEncryptedFileEmpty;
		}

		public TLInputEncryptedFileUploaded ToTLInputEncryptedFileUploaded()
		{
			return this as TLInputEncryptedFileUploaded;
		}

		public TLInputEncryptedFile ToTLInputEncryptedFile()
		{
			return this as TLInputEncryptedFile;
		}

		public TLInputEncryptedFileBigUploaded ToTLInputEncryptedFileBigUploaded()
		{
			return this as TLInputEncryptedFileBigUploaded;
		}

    }
}
