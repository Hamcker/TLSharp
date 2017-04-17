using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsPrivacyKeyTypes
	{
		TLPrivacyKeyStatusTimestamp,TLPrivacyKeyChatInvite,TLPrivacyKeyPhoneCall
	}

    public abstract class TLAbsPrivacyKey : TLObject
    {
		public TLAbsPrivacyKeyTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPrivacyKey
        {
            return this as T;
        }

		public TLPrivacyKeyStatusTimestamp ToTLPrivacyKeyStatusTimestamp()
		{
			return this as TLPrivacyKeyStatusTimestamp;
		}

		public TLPrivacyKeyChatInvite ToTLPrivacyKeyChatInvite()
		{
			return this as TLPrivacyKeyChatInvite;
		}

		public TLPrivacyKeyPhoneCall ToTLPrivacyKeyPhoneCall()
		{
			return this as TLPrivacyKeyPhoneCall;
		}

    }
}
