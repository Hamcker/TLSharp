using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsBotInlineMessageTypes
	{
		TLBotInlineMessageMediaAuto,TLBotInlineMessageText,TLBotInlineMessageMediaGeo,TLBotInlineMessageMediaVenue,TLBotInlineMessageMediaContact
	}

    public abstract class TLAbsBotInlineMessage : TLObject
    {
		public TLAbsBotInlineMessageTypes Type { get; set; } 

		public T To<T>() where T : TLAbsBotInlineMessage
        {
            return this as T;
        }

		public TLBotInlineMessageMediaAuto ToTLBotInlineMessageMediaAuto()
		{
			return this as TLBotInlineMessageMediaAuto;
		}

		public TLBotInlineMessageText ToTLBotInlineMessageText()
		{
			return this as TLBotInlineMessageText;
		}

		public TLBotInlineMessageMediaGeo ToTLBotInlineMessageMediaGeo()
		{
			return this as TLBotInlineMessageMediaGeo;
		}

		public TLBotInlineMessageMediaVenue ToTLBotInlineMessageMediaVenue()
		{
			return this as TLBotInlineMessageMediaVenue;
		}

		public TLBotInlineMessageMediaContact ToTLBotInlineMessageMediaContact()
		{
			return this as TLBotInlineMessageMediaContact;
		}

    }
}
