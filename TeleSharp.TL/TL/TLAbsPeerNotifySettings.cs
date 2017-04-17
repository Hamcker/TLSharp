using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsPeerNotifySettingsTypes
	{
		TLPeerNotifySettingsEmpty,TLPeerNotifySettings
	}

    public abstract class TLAbsPeerNotifySettings : TLObject
    {
		public TLAbsPeerNotifySettingsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPeerNotifySettings
        {
            return this as T;
        }

		public TLPeerNotifySettingsEmpty ToTLPeerNotifySettingsEmpty()
		{
			return this as TLPeerNotifySettingsEmpty;
		}

		public TLPeerNotifySettings ToTLPeerNotifySettings()
		{
			return this as TLPeerNotifySettings;
		}

    }
}
