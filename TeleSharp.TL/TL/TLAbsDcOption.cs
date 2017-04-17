using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsDcOptionTypes
	{
		TLDcOption
	}

    public abstract class TLAbsDcOption : TLObject
    {
		public TLAbsDcOptionTypes Type { get; set; } 

		public T To<T>() where T : TLAbsDcOption
        {
            return this as T;
        }

		public TLDcOption ToTLDcOption()
		{
			return this as TLDcOption;
		}

    }
}
