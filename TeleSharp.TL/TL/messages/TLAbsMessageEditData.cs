using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsMessageEditDataTypes
	{
		TLMessageEditData
	}

    public abstract class TLAbsMessageEditData : TLObject
    {
		public TLAbsMessageEditDataTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMessageEditData
        {
            return this as T;
        }

		public TLMessageEditData ToTLMessageEditData()
		{
			return this as TLMessageEditData;
		}

    }
}
