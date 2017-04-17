using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Contacts
{
	public enum TLAbsLinkTypes
	{
		TLLink
	}

    public abstract class TLAbsLink : TLObject
    {
		public TLAbsLinkTypes Type { get; set; } 

		public T To<T>() where T : TLAbsLink
        {
            return this as T;
        }

		public TLLink ToTLLink()
		{
			return this as TLLink;
		}

    }
}
