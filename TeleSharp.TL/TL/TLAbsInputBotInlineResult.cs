using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputBotInlineResultTypes
	{
		TLInputBotInlineResult,TLInputBotInlineResultPhoto,TLInputBotInlineResultDocument,TLInputBotInlineResultGame
	}

    public abstract class TLAbsInputBotInlineResult : TLObject
    {
		public TLAbsInputBotInlineResultTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputBotInlineResult
        {
            return this as T;
        }

		public TLInputBotInlineResult ToTLInputBotInlineResult()
		{
			return this as TLInputBotInlineResult;
		}

		public TLInputBotInlineResultPhoto ToTLInputBotInlineResultPhoto()
		{
			return this as TLInputBotInlineResultPhoto;
		}

		public TLInputBotInlineResultDocument ToTLInputBotInlineResultDocument()
		{
			return this as TLInputBotInlineResultDocument;
		}

		public TLInputBotInlineResultGame ToTLInputBotInlineResultGame()
		{
			return this as TLInputBotInlineResultGame;
		}

    }
}
