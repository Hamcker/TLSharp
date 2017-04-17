using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsPeerDialogsTypes
	{
		TLPeerDialogs
	}

    public abstract class TLAbsPeerDialogs : TLObject
    {
		public TLAbsPeerDialogsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPeerDialogs
        {
            return this as T;
        }

		public TLPeerDialogs ToTLPeerDialogs()
		{
			return this as TLPeerDialogs;
		}

    }
}
