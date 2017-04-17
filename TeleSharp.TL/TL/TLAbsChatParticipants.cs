using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsChatParticipantsTypes
	{
		TLChatParticipantsForbidden,TLChatParticipants
	}

    public abstract class TLAbsChatParticipants : TLObject
    {
		public TLAbsChatParticipantsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsChatParticipants
        {
            return this as T;
        }

		public TLChatParticipantsForbidden ToTLChatParticipantsForbidden()
		{
			return this as TLChatParticipantsForbidden;
		}

		public TLChatParticipants ToTLChatParticipants()
		{
			return this as TLChatParticipants;
		}

    }
}
