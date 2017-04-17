using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsNewSessionTypes
	{
		TLNew_session_created
	}

    public abstract class TLAbsNewSession : TLObject
    {
		public TLAbsNewSessionTypes Type { get; set; } 

		public T To<T>() where T : TLAbsNewSession
        {
            return this as T;
        }

		public TLNew_session_created ToTLNew_session_created()
		{
			return this as TLNew_session_created;
		}

    }
}
