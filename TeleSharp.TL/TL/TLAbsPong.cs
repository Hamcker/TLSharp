using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsPongTypes
	{
		TLPong
	}

    public abstract class TLAbsPong : TLObject
    {
		public TLAbsPongTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPong
        {
            return this as T;
        }

		public TLPong ToTLPong()
		{
			return this as TLPong;
		}

    }
}
