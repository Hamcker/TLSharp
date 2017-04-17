using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsEncryptedChatTypes
	{
		TLEncryptedChatEmpty,TLEncryptedChatWaiting,TLEncryptedChatRequested,TLEncryptedChat,TLEncryptedChatDiscarded
	}

    public abstract class TLAbsEncryptedChat : TLObject
    {
		public TLAbsEncryptedChatTypes Type { get; set; } 

		public T To<T>() where T : TLAbsEncryptedChat
        {
            return this as T;
        }

		public TLEncryptedChatEmpty ToTLEncryptedChatEmpty()
		{
			return this as TLEncryptedChatEmpty;
		}

		public TLEncryptedChatWaiting ToTLEncryptedChatWaiting()
		{
			return this as TLEncryptedChatWaiting;
		}

		public TLEncryptedChatRequested ToTLEncryptedChatRequested()
		{
			return this as TLEncryptedChatRequested;
		}

		public TLEncryptedChat ToTLEncryptedChat()
		{
			return this as TLEncryptedChat;
		}

		public TLEncryptedChatDiscarded ToTLEncryptedChatDiscarded()
		{
			return this as TLEncryptedChatDiscarded;
		}

    }
}
