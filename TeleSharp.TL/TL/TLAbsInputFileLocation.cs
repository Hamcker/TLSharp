using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputFileLocationTypes
	{
		TLInputFileLocation,TLInputEncryptedFileLocation,TLInputDocumentFileLocation
	}

    public abstract class TLAbsInputFileLocation : TLObject
    {
		public TLAbsInputFileLocationTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputFileLocation
        {
            return this as T;
        }

		public TLInputFileLocation ToTLInputFileLocation()
		{
			return this as TLInputFileLocation;
		}

		public TLInputEncryptedFileLocation ToTLInputEncryptedFileLocation()
		{
			return this as TLInputEncryptedFileLocation;
		}

		public TLInputDocumentFileLocation ToTLInputDocumentFileLocation()
		{
			return this as TLInputDocumentFileLocation;
		}

    }
}
