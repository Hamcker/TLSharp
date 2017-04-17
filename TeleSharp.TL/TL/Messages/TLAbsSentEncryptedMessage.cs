using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsSentEncryptedMessageTypes
	{
		TLSentEncryptedMessage,TLSentEncryptedFile
	}

    public abstract class TLAbsSentEncryptedMessage : TLObject
    {
		public TLAbsSentEncryptedMessageTypes Type { get; set; } 

		public T To<T>() where T : TLAbsSentEncryptedMessage
        {
            return this as T;
        }

		public TLSentEncryptedMessage ToTLSentEncryptedMessage()
		{
			return this as TLSentEncryptedMessage;
		}

		public TLSentEncryptedFile ToTLSentEncryptedFile()
		{
			return this as TLSentEncryptedFile;
		}

    }
}
