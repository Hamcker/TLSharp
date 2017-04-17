using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Help
{
	public enum TLAbsSupportTypes
	{
		TLSupport
	}

    public abstract class TLAbsSupport : TLObject
    {
		public TLAbsSupportTypes Type { get; set; } 

		public T To<T>() where T : TLAbsSupport
        {
            return this as T;
        }

		public TLSupport ToTLSupport()
		{
			return this as TLSupport;
		}

    }
}
