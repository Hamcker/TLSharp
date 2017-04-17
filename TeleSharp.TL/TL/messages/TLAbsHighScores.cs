using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsHighScoresTypes
	{
		TLHighScores
	}

    public abstract class TLAbsHighScores : TLObject
    {
		public TLAbsHighScoresTypes Type { get; set; } 

		public T To<T>() where T : TLAbsHighScores
        {
            return this as T;
        }

		public TLHighScores ToTLHighScores()
		{
			return this as TLHighScores;
		}

    }
}
