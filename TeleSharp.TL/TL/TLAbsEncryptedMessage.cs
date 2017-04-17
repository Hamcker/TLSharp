using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsEncryptedMessageTypes
	{
		TLEncryptedMessage,TLEncryptedMessageService
	}

    public abstract class TLAbsEncryptedMessage : TLObject
    {
		public TLAbsEncryptedMessageTypes Type { get; set; } 

		public T To<T>() where T : TLAbsEncryptedMessage
        {
            return this as T;
        }

		public TLEncryptedMessage ToTLEncryptedMessage()
		{
			return this as TLEncryptedMessage;
		}

		public TLEncryptedMessageService ToTLEncryptedMessageService()
		{
			return this as TLEncryptedMessageService;
		}

    }
}
