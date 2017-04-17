using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputBotInlineMessageIDTypes
	{
		TLInputBotInlineMessageID
	}

    public abstract class TLAbsInputBotInlineMessageID : TLObject
    {
		public TLAbsInputBotInlineMessageIDTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputBotInlineMessageID
        {
            return this as T;
        }

		public TLInputBotInlineMessageID ToTLInputBotInlineMessageID()
		{
			return this as TLInputBotInlineMessageID;
		}

    }
}
