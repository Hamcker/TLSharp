using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsChatParticipantTypes
	{
		TLChatParticipant,TLChatParticipantCreator,TLChatParticipantAdmin
	}

    public abstract class TLAbsChatParticipant : TLObject
    {
		public TLAbsChatParticipantTypes Type { get; set; } 

		public T To<T>() where T : TLAbsChatParticipant
        {
            return this as T;
        }

		public TLChatParticipant ToTLChatParticipant()
		{
			return this as TLChatParticipant;
		}

		public TLChatParticipantCreator ToTLChatParticipantCreator()
		{
			return this as TLChatParticipantCreator;
		}

		public TLChatParticipantAdmin ToTLChatParticipantAdmin()
		{
			return this as TLChatParticipantAdmin;
		}

    }
}
