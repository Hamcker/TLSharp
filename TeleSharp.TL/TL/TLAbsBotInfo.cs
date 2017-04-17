using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsBotInfoTypes
	{
		TLBotInfo
	}

    public abstract class TLAbsBotInfo : TLObject
    {
		public TLAbsBotInfoTypes Type { get; set; } 

		public T To<T>() where T : TLAbsBotInfo
        {
            return this as T;
        }

		public TLBotInfo ToTLBotInfo()
		{
			return this as TLBotInfo;
		}

    }
}
