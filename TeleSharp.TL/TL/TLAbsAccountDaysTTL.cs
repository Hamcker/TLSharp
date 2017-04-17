using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsAccountDaysTTLTypes
	{
		TLAccountDaysTTL
	}

    public abstract class TLAbsAccountDaysTTL : TLObject
    {
		public TLAbsAccountDaysTTLTypes Type { get; set; } 

		public T To<T>() where T : TLAbsAccountDaysTTL
        {
            return this as T;
        }

		public TLAccountDaysTTL ToTLAccountDaysTTL()
		{
			return this as TLAccountDaysTTL;
		}

    }
}
