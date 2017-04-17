using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Contacts
{
	public enum TLAbsImportedContactsTypes
	{
		TLImportedContacts
	}

    public abstract class TLAbsImportedContacts : TLObject
    {
		public TLAbsImportedContactsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsImportedContacts
        {
            return this as T;
        }

		public TLImportedContacts ToTLImportedContacts()
		{
			return this as TLImportedContacts;
		}

    }
}
