using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Updates
{
	public enum TLAbsStateTypes
	{
		TLState
	}

    public abstract class TLAbsState : TLObject
    {
		public TLAbsStateTypes Type { get; set; } 

		public T To<T>() where T : TLAbsState
        {
            return this as T;
        }

		public TLState ToTLState()
		{
			return this as TLState;
		}

    }
}
