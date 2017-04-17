using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsFutureSaltTypes
	{
		TLFuture_salt
	}

    public abstract class TLAbsFutureSalt : TLObject
    {
		public TLAbsFutureSaltTypes Type { get; set; } 

		public T To<T>() where T : TLAbsFutureSalt
        {
            return this as T;
        }

		public TLFuture_salt ToTLFuture_salt()
		{
			return this as TLFuture_salt;
		}

    }
}
