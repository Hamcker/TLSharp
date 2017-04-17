using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputDocumentTypes
	{
		TLInputDocumentEmpty,TLInputDocument
	}

    public abstract class TLAbsInputDocument : TLObject
    {
		public TLAbsInputDocumentTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputDocument
        {
            return this as T;
        }

		public TLInputDocumentEmpty ToTLInputDocumentEmpty()
		{
			return this as TLInputDocumentEmpty;
		}

		public TLInputDocument ToTLInputDocument()
		{
			return this as TLInputDocument;
		}

    }
}
