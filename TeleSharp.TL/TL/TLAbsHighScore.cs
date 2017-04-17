using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsHighScoreTypes
	{
		TLHighScore
	}

    public abstract class TLAbsHighScore : TLObject
    {
		public TLAbsHighScoreTypes Type { get; set; } 

		public T To<T>() where T : TLAbsHighScore
        {
            return this as T;
        }

		public TLHighScore ToTLHighScore()
		{
			return this as TLHighScore;
		}

    }
}
