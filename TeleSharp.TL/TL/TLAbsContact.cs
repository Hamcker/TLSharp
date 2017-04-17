using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsContactTypes
	{
		TLContact
	}

    public abstract class TLAbsContact : TLObject
    {
		public TLAbsContactTypes Type { get; set; } 

		public T To<T>() where T : TLAbsContact
        {
            return this as T;
        }

		public TLContact ToTLContact()
		{
			return this as TLContact;
		}

    }
}
