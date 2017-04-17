using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputPrivacyRuleTypes
	{
		TLInputPrivacyValueAllowContacts,TLInputPrivacyValueAllowAll,TLInputPrivacyValueAllowUsers,TLInputPrivacyValueDisallowContacts,TLInputPrivacyValueDisallowAll,TLInputPrivacyValueDisallowUsers
	}

    public abstract class TLAbsInputPrivacyRule : TLObject
    {
		public TLAbsInputPrivacyRuleTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputPrivacyRule
        {
            return this as T;
        }

		public TLInputPrivacyValueAllowContacts ToTLInputPrivacyValueAllowContacts()
		{
			return this as TLInputPrivacyValueAllowContacts;
		}

		public TLInputPrivacyValueAllowAll ToTLInputPrivacyValueAllowAll()
		{
			return this as TLInputPrivacyValueAllowAll;
		}

		public TLInputPrivacyValueAllowUsers ToTLInputPrivacyValueAllowUsers()
		{
			return this as TLInputPrivacyValueAllowUsers;
		}

		public TLInputPrivacyValueDisallowContacts ToTLInputPrivacyValueDisallowContacts()
		{
			return this as TLInputPrivacyValueDisallowContacts;
		}

		public TLInputPrivacyValueDisallowAll ToTLInputPrivacyValueDisallowAll()
		{
			return this as TLInputPrivacyValueDisallowAll;
		}

		public TLInputPrivacyValueDisallowUsers ToTLInputPrivacyValueDisallowUsers()
		{
			return this as TLInputPrivacyValueDisallowUsers;
		}

    }
}
