using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsPageTypes
	{
		TLPagePart,TLPageFull
	}

    public abstract class TLAbsPage : TLObject
    {
		public TLAbsPageTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPage
        {
            return this as T;
        }

		public TLPagePart ToTLPagePart()
		{
			return this as TLPagePart;
		}

		public TLPageFull ToTLPageFull()
		{
			return this as TLPageFull;
		}

    }
}
