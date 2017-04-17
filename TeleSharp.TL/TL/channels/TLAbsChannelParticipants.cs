using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Channels
{
	public enum TLAbsChannelParticipantsTypes
	{
		TLChannelParticipants
	}

    public abstract class TLAbsChannelParticipants : TLObject
    {
		public TLAbsChannelParticipantsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsChannelParticipants
        {
            return this as T;
        }

		public TLChannelParticipants ToTLChannelParticipants()
		{
			return this as TLChannelParticipants;
		}

    }
}
