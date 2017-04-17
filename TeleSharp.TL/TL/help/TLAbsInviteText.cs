using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Help
{
	public enum TLAbsInviteTextTypes
	{
		TLInviteText
	}

    public abstract class TLAbsInviteText : TLObject
    {
		public TLAbsInviteTextTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInviteText
        {
            return this as T;
        }

		public TLInviteText ToTLInviteText()
		{
			return this as TLInviteText;
		}

    }
}
