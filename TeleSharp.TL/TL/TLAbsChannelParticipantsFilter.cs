using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsChannelParticipantsFilterTypes
	{
		TLChannelParticipantsRecent,TLChannelParticipantsAdmins,TLChannelParticipantsKicked,TLChannelParticipantsBots
	}

    public abstract class TLAbsChannelParticipantsFilter : TLObject
    {
		public TLAbsChannelParticipantsFilterTypes Type { get; set; } 

		public T To<T>() where T : TLAbsChannelParticipantsFilter
        {
            return this as T;
        }

		public TLChannelParticipantsRecent ToTLChannelParticipantsRecent()
		{
			return this as TLChannelParticipantsRecent;
		}

		public TLChannelParticipantsAdmins ToTLChannelParticipantsAdmins()
		{
			return this as TLChannelParticipantsAdmins;
		}

		public TLChannelParticipantsKicked ToTLChannelParticipantsKicked()
		{
			return this as TLChannelParticipantsKicked;
		}

		public TLChannelParticipantsBots ToTLChannelParticipantsBots()
		{
			return this as TLChannelParticipantsBots;
		}

    }
}
