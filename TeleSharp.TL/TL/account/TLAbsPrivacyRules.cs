using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Account
{
	public enum TLAbsPrivacyRulesTypes
	{
		TLPrivacyRules
	}

    public abstract class TLAbsPrivacyRules : TLObject
    {
		public TLAbsPrivacyRulesTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPrivacyRules
        {
            return this as T;
        }

		public TLPrivacyRules ToTLPrivacyRules()
		{
			return this as TLPrivacyRules;
		}

    }
}
