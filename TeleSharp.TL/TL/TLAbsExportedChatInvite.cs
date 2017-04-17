using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsExportedChatInviteTypes
	{
		TLChatInviteEmpty,TLChatInviteExported
	}

    public abstract class TLAbsExportedChatInvite : TLObject
    {
		public TLAbsExportedChatInviteTypes Type { get; set; } 

		public T To<T>() where T : TLAbsExportedChatInvite
        {
            return this as T;
        }

		public TLChatInviteEmpty ToTLChatInviteEmpty()
		{
			return this as TLChatInviteEmpty;
		}

		public TLChatInviteExported ToTLChatInviteExported()
		{
			return this as TLChatInviteExported;
		}

    }
}
