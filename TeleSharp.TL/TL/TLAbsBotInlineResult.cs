using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsBotInlineResultTypes
	{
		TLBotInlineResult,TLBotInlineMediaResult
	}

    public abstract class TLAbsBotInlineResult : TLObject
    {
		public TLAbsBotInlineResultTypes Type { get; set; } 

		public T To<T>() where T : TLAbsBotInlineResult
        {
            return this as T;
        }

		public TLBotInlineResult ToTLBotInlineResult()
		{
			return this as TLBotInlineResult;
		}

		public TLBotInlineMediaResult ToTLBotInlineMediaResult()
		{
			return this as TLBotInlineMediaResult;
		}

    }
}
