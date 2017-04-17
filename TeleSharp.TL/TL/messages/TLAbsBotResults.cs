using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsBotResultsTypes
	{
		TLBotResults
	}

    public abstract class TLAbsBotResults : TLObject
    {
		public TLAbsBotResultsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsBotResults
        {
            return this as T;
        }

		public TLBotResults ToTLBotResults()
		{
			return this as TLBotResults;
		}

    }
}
