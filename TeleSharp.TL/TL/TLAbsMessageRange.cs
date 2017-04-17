using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsMessageRangeTypes
	{
		TLMessageRange
	}

    public abstract class TLAbsMessageRange : TLObject
    {
		public TLAbsMessageRangeTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMessageRange
        {
            return this as T;
        }

		public TLMessageRange ToTLMessageRange()
		{
			return this as TLMessageRange;
		}

    }
}
