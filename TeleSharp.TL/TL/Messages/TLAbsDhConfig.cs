using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsDhConfigTypes
	{
		TLDhConfigNotModified,TLDhConfig
	}

    public abstract class TLAbsDhConfig : TLObject
    {
		public TLAbsDhConfigTypes Type { get; set; } 

		public T To<T>() where T : TLAbsDhConfig
        {
            return this as T;
        }

		public TLDhConfigNotModified ToTLDhConfigNotModified()
		{
			return this as TLDhConfigNotModified;
		}

		public TLDhConfig ToTLDhConfig()
		{
			return this as TLDhConfig;
		}

    }
}
