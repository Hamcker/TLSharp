using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputContactTypes
	{
		TLInputPhoneContact
	}

    public abstract class TLAbsInputContact : TLObject
    {
		public TLAbsInputContactTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputContact
        {
            return this as T;
        }

		public TLInputPhoneContact ToTLInputPhoneContact()
		{
			return this as TLInputPhoneContact;
		}

    }
}
