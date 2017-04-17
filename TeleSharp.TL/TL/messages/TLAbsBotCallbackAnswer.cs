using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsBotCallbackAnswerTypes
	{
		TLBotCallbackAnswer
	}

    public abstract class TLAbsBotCallbackAnswer : TLObject
    {
		public TLAbsBotCallbackAnswerTypes Type { get; set; } 

		public T To<T>() where T : TLAbsBotCallbackAnswer
        {
            return this as T;
        }

		public TLBotCallbackAnswer ToTLBotCallbackAnswer()
		{
			return this as TLBotCallbackAnswer;
		}

    }
}
