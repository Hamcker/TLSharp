using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputEncryptedChatTypes
	{
		TLInputEncryptedChat
	}

    public abstract class TLAbsInputEncryptedChat : TLObject
    {
		public TLAbsInputEncryptedChatTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputEncryptedChat
        {
            return this as T;
        }

		public TLInputEncryptedChat ToTLInputEncryptedChat()
		{
			return this as TLInputEncryptedChat;
		}

    }
}
