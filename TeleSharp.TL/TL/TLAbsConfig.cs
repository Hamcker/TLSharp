using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsConfigTypes
	{
		TLConfig
	}

    public abstract class TLAbsConfig : TLObject
    {
		public TLAbsConfigTypes Type { get; set; } 

		public T To<T>() where T : TLAbsConfig
        {
            return this as T;
        }

		public TLConfig ToTLConfig()
		{
			return this as TLConfig;
		}

    }
}
