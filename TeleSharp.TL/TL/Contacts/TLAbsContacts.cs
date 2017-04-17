using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Contacts
{
	public enum TLAbsContactsTypes
	{
		TLContactsNotModified,TLContacts
	}

    public abstract class TLAbsContacts : TLObject
    {
		public TLAbsContactsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsContacts
        {
            return this as T;
        }

		public TLContactsNotModified ToTLContactsNotModified()
		{
			return this as TLContactsNotModified;
		}

		public TLContacts ToTLContacts()
		{
			return this as TLContacts;
		}

    }
}
