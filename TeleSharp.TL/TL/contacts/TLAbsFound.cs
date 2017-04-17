using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Contacts
{
	public enum TLAbsFoundTypes
	{
		TLFound
	}

    public abstract class TLAbsFound : TLObject
    {
		public TLAbsFoundTypes Type { get; set; } 

		public T To<T>() where T : TLAbsFound
        {
            return this as T;
        }

		public TLFound ToTLFound()
		{
			return this as TLFound;
		}

    }
}
