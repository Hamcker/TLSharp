using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsMessageTypes
	{
		TLMessageEmpty,TLMessage,TLMessageService
	}

    public abstract class TLAbsMessage : TLObject
    {
		public TLAbsMessageTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMessage
        {
            return this as T;
        }

		public TLMessageEmpty ToTLMessageEmpty()
		{
			return this as TLMessageEmpty;
		}

		public TLMessage ToTLMessage()
		{
			return this as TLMessage;
		}

		public TLMessageService ToTLMessageService()
		{
			return this as TLMessageService;
		}

    }
}
