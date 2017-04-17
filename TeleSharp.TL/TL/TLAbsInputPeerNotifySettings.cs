using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputPeerNotifySettingsTypes
	{
		TLInputPeerNotifySettings
	}

    public abstract class TLAbsInputPeerNotifySettings : TLObject
    {
		public TLAbsInputPeerNotifySettingsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputPeerNotifySettings
        {
            return this as T;
        }

		public TLInputPeerNotifySettings ToTLInputPeerNotifySettings()
		{
			return this as TLInputPeerNotifySettings;
		}

    }
}
