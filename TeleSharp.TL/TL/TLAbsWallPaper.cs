using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsWallPaperTypes
	{
		TLWallPaper,TLWallPaperSolid
	}

    public abstract class TLAbsWallPaper : TLObject
    {
		public TLAbsWallPaperTypes Type { get; set; } 

		public T To<T>() where T : TLAbsWallPaper
        {
            return this as T;
        }

		public TLWallPaper ToTLWallPaper()
		{
			return this as TLWallPaper;
		}

		public TLWallPaperSolid ToTLWallPaperSolid()
		{
			return this as TLWallPaperSolid;
		}

    }
}
