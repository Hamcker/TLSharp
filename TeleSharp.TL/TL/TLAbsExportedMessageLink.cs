using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsExportedMessageLinkTypes
	{
		TLExportedMessageLink
	}

    public abstract class TLAbsExportedMessageLink : TLObject
    {
		public TLAbsExportedMessageLinkTypes Type { get; set; } 

		public T To<T>() where T : TLAbsExportedMessageLink
        {
            return this as T;
        }

		public TLExportedMessageLink ToTLExportedMessageLink()
		{
			return this as TLExportedMessageLink;
		}

    }
}
