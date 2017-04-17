using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputPrivacyKeyTypes
	{
		TLInputPrivacyKeyStatusTimestamp,TLInputPrivacyKeyChatInvite,TLInputPrivacyKeyPhoneCall
	}

    public abstract class TLAbsInputPrivacyKey : TLObject
    {
		public TLAbsInputPrivacyKeyTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputPrivacyKey
        {
            return this as T;
        }

		public TLInputPrivacyKeyStatusTimestamp ToTLInputPrivacyKeyStatusTimestamp()
		{
			return this as TLInputPrivacyKeyStatusTimestamp;
		}

		public TLInputPrivacyKeyChatInvite ToTLInputPrivacyKeyChatInvite()
		{
			return this as TLInputPrivacyKeyChatInvite;
		}

		public TLInputPrivacyKeyPhoneCall ToTLInputPrivacyKeyPhoneCall()
		{
			return this as TLInputPrivacyKeyPhoneCall;
		}

    }
}
