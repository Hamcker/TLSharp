using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputBotInlineMessageTypes
	{
		TLInputBotInlineMessageMediaAuto,TLInputBotInlineMessageText,TLInputBotInlineMessageMediaGeo,TLInputBotInlineMessageMediaVenue,TLInputBotInlineMessageMediaContact,TLInputBotInlineMessageGame
	}

    public abstract class TLAbsInputBotInlineMessage : TLObject
    {
		public TLAbsInputBotInlineMessageTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputBotInlineMessage
        {
            return this as T;
        }

		public TLInputBotInlineMessageMediaAuto ToTLInputBotInlineMessageMediaAuto()
		{
			return this as TLInputBotInlineMessageMediaAuto;
		}

		public TLInputBotInlineMessageText ToTLInputBotInlineMessageText()
		{
			return this as TLInputBotInlineMessageText;
		}

		public TLInputBotInlineMessageMediaGeo ToTLInputBotInlineMessageMediaGeo()
		{
			return this as TLInputBotInlineMessageMediaGeo;
		}

		public TLInputBotInlineMessageMediaVenue ToTLInputBotInlineMessageMediaVenue()
		{
			return this as TLInputBotInlineMessageMediaVenue;
		}

		public TLInputBotInlineMessageMediaContact ToTLInputBotInlineMessageMediaContact()
		{
			return this as TLInputBotInlineMessageMediaContact;
		}

		public TLInputBotInlineMessageGame ToTLInputBotInlineMessageGame()
		{
			return this as TLInputBotInlineMessageGame;
		}

    }
}
