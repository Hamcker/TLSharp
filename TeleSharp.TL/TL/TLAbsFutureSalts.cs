using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsFutureSaltsTypes
	{
		TLFuture_salts
	}

    public abstract class TLAbsFutureSalts : TLObject
    {
		public TLAbsFutureSaltsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsFutureSalts
        {
            return this as T;
        }

		public TLFuture_salts ToTLFuture_salts()
		{
			return this as TLFuture_salts;
		}

    }
}
