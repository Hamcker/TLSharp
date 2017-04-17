using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsImportedContactTypes
	{
		TLImportedContact
	}

    public abstract class TLAbsImportedContact : TLObject
    {
		public TLAbsImportedContactTypes Type { get; set; } 

		public T To<T>() where T : TLAbsImportedContact
        {
            return this as T;
        }

		public TLImportedContact ToTLImportedContact()
		{
			return this as TLImportedContact;
		}

    }
}
