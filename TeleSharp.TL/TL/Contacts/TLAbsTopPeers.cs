using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Contacts
{
	public enum TLAbsTopPeersTypes
	{
		TLTopPeersNotModified,TLTopPeers
	}

    public abstract class TLAbsTopPeers : TLObject
    {
		public TLAbsTopPeersTypes Type { get; set; } 

		public T To<T>() where T : TLAbsTopPeers
        {
            return this as T;
        }

		public TLTopPeersNotModified ToTLTopPeersNotModified()
		{
			return this as TLTopPeersNotModified;
		}

		public TLTopPeers ToTLTopPeers()
		{
			return this as TLTopPeers;
		}

    }
}
