using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputAppEventTypes
	{
		TLInputAppEvent
	}

    public abstract class TLAbsInputAppEvent : TLObject
    {
		public TLAbsInputAppEventTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputAppEvent
        {
            return this as T;
        }

		public TLInputAppEvent ToTLInputAppEvent()
		{
			return this as TLInputAppEvent;
		}

    }
}
