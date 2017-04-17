using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsPeerSettingsTypes
	{
		TLPeerSettings
	}

    public abstract class TLAbsPeerSettings : TLObject
    {
		public TLAbsPeerSettingsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPeerSettings
        {
            return this as T;
        }

		public TLPeerSettings ToTLPeerSettings()
		{
			return this as TLPeerSettings;
		}

    }
}
