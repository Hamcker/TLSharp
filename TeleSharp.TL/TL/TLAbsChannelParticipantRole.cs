using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsChannelParticipantRoleTypes
	{
		TLChannelRoleEmpty,TLChannelRoleModerator,TLChannelRoleEditor
	}

    public abstract class TLAbsChannelParticipantRole : TLObject
    {
		public TLAbsChannelParticipantRoleTypes Type { get; set; } 

		public T To<T>() where T : TLAbsChannelParticipantRole
        {
            return this as T;
        }

		public TLChannelRoleEmpty ToTLChannelRoleEmpty()
		{
			return this as TLChannelRoleEmpty;
		}

		public TLChannelRoleModerator ToTLChannelRoleModerator()
		{
			return this as TLChannelRoleModerator;
		}

		public TLChannelRoleEditor ToTLChannelRoleEditor()
		{
			return this as TLChannelRoleEditor;
		}

    }
}
