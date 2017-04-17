using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsHttpWaitTypes
	{
		TLHttp_wait
	}

    public abstract class TLAbsHttpWait : TLObject
    {
		public TLAbsHttpWaitTypes Type { get; set; } 

		public T To<T>() where T : TLAbsHttpWait
        {
            return this as T;
        }

		public TLHttp_wait ToTLHttp_wait()
		{
			return this as TLHttp_wait;
		}

    }
}
