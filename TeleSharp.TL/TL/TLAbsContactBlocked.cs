using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsContactBlockedTypes
	{
		TLContactBlocked
	}

    public abstract class TLAbsContactBlocked : TLObject
    {
		public TLAbsContactBlockedTypes Type { get; set; } 

		public T To<T>() where T : TLAbsContactBlocked
        {
            return this as T;
        }

		public TLContactBlocked ToTLContactBlocked()
		{
			return this as TLContactBlocked;
		}

    }
}
