using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsGameTypes
	{
		TLGame
	}

    public abstract class TLAbsGame : TLObject
    {
		public TLAbsGameTypes Type { get; set; } 

		public T To<T>() where T : TLAbsGame
        {
            return this as T;
        }

		public TLGame ToTLGame()
		{
			return this as TLGame;
		}

    }
}
