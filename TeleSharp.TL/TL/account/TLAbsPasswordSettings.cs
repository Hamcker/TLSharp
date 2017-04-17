using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Account
{
	public enum TLAbsPasswordSettingsTypes
	{
		TLPasswordSettings
	}

    public abstract class TLAbsPasswordSettings : TLObject
    {
		public TLAbsPasswordSettingsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPasswordSettings
        {
            return this as T;
        }

		public TLPasswordSettings ToTLPasswordSettings()
		{
			return this as TLPasswordSettings;
		}

    }
}
