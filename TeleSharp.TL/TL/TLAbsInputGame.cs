using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputGameTypes
	{
		TLInputGameID,TLInputGameShortName
	}

    public abstract class TLAbsInputGame : TLObject
    {
		public TLAbsInputGameTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputGame
        {
            return this as T;
        }

		public TLInputGameID ToTLInputGameID()
		{
			return this as TLInputGameID;
		}

		public TLInputGameShortName ToTLInputGameShortName()
		{
			return this as TLInputGameShortName;
		}

    }
}
