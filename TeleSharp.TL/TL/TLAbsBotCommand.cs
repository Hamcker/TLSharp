using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsBotCommandTypes
	{
		TLBotCommand
	}

    public abstract class TLAbsBotCommand : TLObject
    {
		public TLAbsBotCommandTypes Type { get; set; } 

		public T To<T>() where T : TLAbsBotCommand
        {
            return this as T;
        }

		public TLBotCommand ToTLBotCommand()
		{
			return this as TLBotCommand;
		}

    }
}
