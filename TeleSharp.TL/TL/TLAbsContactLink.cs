using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsContactLinkTypes
	{
		TLContactLinkUnknown,TLContactLinkNone,TLContactLinkHasPhone,TLContactLinkContact
	}

    public abstract class TLAbsContactLink : TLObject
    {
		public TLAbsContactLinkTypes Type { get; set; } 

		public T To<T>() where T : TLAbsContactLink
        {
            return this as T;
        }

		public TLContactLinkUnknown ToTLContactLinkUnknown()
		{
			return this as TLContactLinkUnknown;
		}

		public TLContactLinkNone ToTLContactLinkNone()
		{
			return this as TLContactLinkNone;
		}

		public TLContactLinkHasPhone ToTLContactLinkHasPhone()
		{
			return this as TLContactLinkHasPhone;
		}

		public TLContactLinkContact ToTLContactLinkContact()
		{
			return this as TLContactLinkContact;
		}

    }
}
