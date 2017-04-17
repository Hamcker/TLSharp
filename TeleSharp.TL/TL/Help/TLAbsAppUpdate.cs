using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Help
{
	public enum TLAbsAppUpdateTypes
	{
		TLAppUpdate,TLNoAppUpdate
	}

    public abstract class TLAbsAppUpdate : TLObject
    {
		public TLAbsAppUpdateTypes Type { get; set; } 

		public T To<T>() where T : TLAbsAppUpdate
        {
            return this as T;
        }

		public TLAppUpdate ToTLAppUpdate()
		{
			return this as TLAppUpdate;
		}

		public TLNoAppUpdate ToTLNoAppUpdate()
		{
			return this as TLNoAppUpdate;
		}

    }
}
