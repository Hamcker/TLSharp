using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsEncryptedFileTypes
	{
		TLEncryptedFileEmpty,TLEncryptedFile
	}

    public abstract class TLAbsEncryptedFile : TLObject
    {
		public TLAbsEncryptedFileTypes Type { get; set; } 

		public T To<T>() where T : TLAbsEncryptedFile
        {
            return this as T;
        }

		public TLEncryptedFileEmpty ToTLEncryptedFileEmpty()
		{
			return this as TLEncryptedFileEmpty;
		}

		public TLEncryptedFile ToTLEncryptedFile()
		{
			return this as TLEncryptedFile;
		}

    }
}
