using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsMessageFwdHeaderTypes
	{
		TLMessageFwdHeader
	}

    public abstract class TLAbsMessageFwdHeader : TLObject
    {
		public TLAbsMessageFwdHeaderTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMessageFwdHeader
        {
            return this as T;
        }

		public TLMessageFwdHeader ToTLMessageFwdHeader()
		{
			return this as TLMessageFwdHeader;
		}

    }
}
