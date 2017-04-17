using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsResPQTypes
	{
		TLResPQ
	}

    public abstract class TLAbsResPQ : TLObject
    {
		public TLAbsResPQTypes Type { get; set; } 

		public T To<T>() where T : TLAbsResPQ
        {
            return this as T;
        }

		public TLResPQ ToTLResPQ()
		{
			return this as TLResPQ;
		}

    }
}
