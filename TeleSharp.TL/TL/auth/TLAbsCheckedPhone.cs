using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Auth
{
	public enum TLAbsCheckedPhoneTypes
	{
		TLCheckedPhone
	}

    public abstract class TLAbsCheckedPhone : TLObject
    {
		public TLAbsCheckedPhoneTypes Type { get; set; } 

		public T To<T>() where T : TLAbsCheckedPhone
        {
            return this as T;
        }

		public TLCheckedPhone ToTLCheckedPhone()
		{
			return this as TLCheckedPhone;
		}

    }
}
