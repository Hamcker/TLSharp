using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Contacts
{
	public enum TLAbsResolvedPeerTypes
	{
		TLResolvedPeer
	}

    public abstract class TLAbsResolvedPeer : TLObject
    {
		public TLAbsResolvedPeerTypes Type { get; set; } 

		public T To<T>() where T : TLAbsResolvedPeer
        {
            return this as T;
        }

		public TLResolvedPeer ToTLResolvedPeer()
		{
			return this as TLResolvedPeer;
		}

    }
}
