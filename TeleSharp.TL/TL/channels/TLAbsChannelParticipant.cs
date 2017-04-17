using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Channels
{
	public enum TLAbsChannelParticipantTypes
	{
		TLChannelParticipant
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

    }
}
