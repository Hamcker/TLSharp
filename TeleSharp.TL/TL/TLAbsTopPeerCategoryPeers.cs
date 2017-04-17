using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsTopPeerCategoryPeersTypes
	{
		TLTopPeerCategoryPeers
	}

    public abstract class TLAbsTopPeerCategoryPeers : TLObject
    {
		public TLAbsTopPeerCategoryPeersTypes Type { get; set; } 

		public T To<T>() where T : TLAbsTopPeerCategoryPeers
        {
            return this as T;
        }

		public TLTopPeerCategoryPeers ToTLTopPeerCategoryPeers()
		{
			return this as TLTopPeerCategoryPeers;
		}

    }
}
