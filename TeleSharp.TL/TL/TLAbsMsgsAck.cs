using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsMsgsAckTypes
	{
		TLMsgs_ack
	}

    public abstract class TLAbsMsgsAck : TLObject
    {
		public TLAbsMsgsAckTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMsgsAck
        {
            return this as T;
        }

		public TLMsgs_ack ToTLMsgs_ack()
		{
			return this as TLMsgs_ack;
		}

    }
}
