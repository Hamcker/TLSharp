using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Account
{
	public enum TLAbsPasswordInputSettingsTypes
	{
		TLPasswordInputSettings
	}

    public abstract class TLAbsPasswordInputSettings : TLObject
    {
		public TLAbsPasswordInputSettingsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPasswordInputSettings
        {
            return this as T;
        }

		public TLPasswordInputSettings ToTLPasswordInputSettings()
		{
			return this as TLPasswordInputSettings;
		}

    }
}
