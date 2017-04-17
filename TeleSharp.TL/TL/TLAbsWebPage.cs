using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsWebPageTypes
	{
		TLWebPageEmpty,TLWebPagePending,TLWebPage,TLWebPageNotModified
	}

    public abstract class TLAbsWebPage : TLObject
    {
		public TLAbsWebPageTypes Type { get; set; } 

		public T To<T>() where T : TLAbsWebPage
        {
            return this as T;
        }

		public TLWebPageEmpty ToTLWebPageEmpty()
		{
			return this as TLWebPageEmpty;
		}

		public TLWebPagePending ToTLWebPagePending()
		{
			return this as TLWebPagePending;
		}

		public TLWebPage ToTLWebPage()
		{
			return this as TLWebPage;
		}

		public TLWebPageNotModified ToTLWebPageNotModified()
		{
			return this as TLWebPageNotModified;
		}

    }
}
