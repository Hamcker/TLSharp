using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Help
{
	public enum TLAbsAppChangelogTypes
	{
		TLAppChangelogEmpty,TLAppChangelog
	}

    public abstract class TLAbsAppChangelog : TLObject
    {
		public TLAbsAppChangelogTypes Type { get; set; } 

		public T To<T>() where T : TLAbsAppChangelog
        {
            return this as T;
        }

		public TLAppChangelogEmpty ToTLAppChangelogEmpty()
		{
			return this as TLAppChangelogEmpty;
		}

		public TLAppChangelog ToTLAppChangelog()
		{
			return this as TLAppChangelog;
		}

    }
}
