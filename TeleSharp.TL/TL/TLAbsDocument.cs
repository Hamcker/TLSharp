using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsDocumentTypes
	{
		TLDocumentEmpty,TLDocument
	}

    public abstract class TLAbsDocument : TLObject
    {
		public TLAbsDocumentTypes Type { get; set; } 

		public T To<T>() where T : TLAbsDocument
        {
            return this as T;
        }

		public TLDocumentEmpty ToTLDocumentEmpty()
		{
			return this as TLDocumentEmpty;
		}

		public TLDocument ToTLDocument()
		{
			return this as TLDocument;
		}

    }
}
