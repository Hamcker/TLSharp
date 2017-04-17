using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsTopPeerTypes
	{
		TLTopPeer
	}

    public abstract class TLAbsTopPeer : TLObject
    {
		public TLAbsTopPeerTypes Type { get; set; } 

		public T To<T>() where T : TLAbsTopPeer
        {
            return this as T;
        }

		public TLTopPeer ToTLTopPeer()
		{
			return this as TLTopPeer;
		}

    }
}
