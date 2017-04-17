using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsChannelParticipantTypes
	{
		TLChannelParticipant,TLChannelParticipantSelf,TLChannelParticipantModerator,TLChannelParticipantEditor,TLChannelParticipantKicked,TLChannelParticipantCreator
	}

    public abstract class TLAbsChannelParticipant : TLObject
    {
		public TLAbsChannelParticipantTypes Type { get; set; } 

		public T To<T>() where T : TLAbsChannelParticipant
        {
            return this as T;
        }

		public TLChannelParticipant ToTLChannelParticipant()
		{
			return this as TLChannelParticipant;
		}

		public TLChannelParticipantSelf ToTLChannelParticipantSelf()
		{
			return this as TLChannelParticipantSelf;
		}

		public TLChannelParticipantModerator ToTLChannelParticipantModerator()
		{
			return this as TLChannelParticipantModerator;
		}

		public TLChannelParticipantEditor ToTLChannelParticipantEditor()
		{
			return this as TLChannelParticipantEditor;
		}

		public TLChannelParticipantKicked ToTLChannelParticipantKicked()
		{
			return this as TLChannelParticipantKicked;
		}

		public TLChannelParticipantCreator ToTLChannelParticipantCreator()
		{
			return this as TLChannelParticipantCreator;
		}

    }
}
