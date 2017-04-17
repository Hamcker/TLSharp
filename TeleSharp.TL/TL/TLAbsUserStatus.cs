using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsUserStatusTypes
	{
		TLUserStatusEmpty,TLUserStatusOnline,TLUserStatusOffline,TLUserStatusRecently,TLUserStatusLastWeek,TLUserStatusLastMonth
	}

    public abstract class TLAbsUserStatus : TLObject
    {
		public TLAbsUserStatusTypes Type { get; set; } 

		public T To<T>() where T : TLAbsUserStatus
        {
            return this as T;
        }

		public TLUserStatusEmpty ToTLUserStatusEmpty()
		{
			return this as TLUserStatusEmpty;
		}

		public TLUserStatusOnline ToTLUserStatusOnline()
		{
			return this as TLUserStatusOnline;
		}

		public TLUserStatusOffline ToTLUserStatusOffline()
		{
			return this as TLUserStatusOffline;
		}

		public TLUserStatusRecently ToTLUserStatusRecently()
		{
			return this as TLUserStatusRecently;
		}

		public TLUserStatusLastWeek ToTLUserStatusLastWeek()
		{
			return this as TLUserStatusLastWeek;
		}

		public TLUserStatusLastMonth ToTLUserStatusLastMonth()
		{
			return this as TLUserStatusLastMonth;
		}

    }
}
