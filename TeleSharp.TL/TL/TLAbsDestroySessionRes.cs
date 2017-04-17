using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsDestroySessionResTypes
	{
		TLDestroy_session_ok,TLDestroy_session_none
	}

    public abstract class TLAbsDestroySessionRes : TLObject
    {
		public TLAbsDestroySessionResTypes Type { get; set; } 

		public T To<T>() where T : TLAbsDestroySessionRes
        {
            return this as T;
        }

		public TLDestroy_session_ok ToTLDestroy_session_ok()
		{
			return this as TLDestroy_session_ok;
		}

		public TLDestroy_session_none ToTLDestroy_session_none()
		{
			return this as TLDestroy_session_none;
		}

    }
}
