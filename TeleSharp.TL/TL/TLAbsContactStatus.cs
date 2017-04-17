using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsContactStatusTypes
	{
		TLContactStatus
	}

    public abstract class TLAbsContactStatus : TLObject
    {
		public TLAbsContactStatusTypes Type { get; set; } 

		public T To<T>() where T : TLAbsContactStatus
        {
            return this as T;
        }

		public TLContactStatus ToTLContactStatus()
		{
			return this as TLContactStatus;
		}

    }
}
