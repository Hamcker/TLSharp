using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsTrueTypes
	{
		TLTrue
	}

    public abstract class TLAbsTrue : TLObject
    {
		public TLAbsTrueTypes Type { get; set; } 

		public T To<T>() where T : TLAbsTrue
        {
            return this as T;
        }

		public TLTrue ToTLTrue()
		{
			return this as TLTrue;
		}

    }
}
