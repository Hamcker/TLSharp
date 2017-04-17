using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsFoundGifsTypes
	{
		TLFoundGifs
	}

    public abstract class TLAbsFoundGifs : TLObject
    {
		public TLAbsFoundGifsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsFoundGifs
        {
            return this as T;
        }

		public TLFoundGifs ToTLFoundGifs()
		{
			return this as TLFoundGifs;
		}

    }
}
